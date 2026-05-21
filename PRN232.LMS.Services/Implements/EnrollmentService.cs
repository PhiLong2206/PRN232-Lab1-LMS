using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Implements;

public class EnrollmentService : IEnrollmentService
{
    private readonly IGenericRepository<Enrollment> _enrollmentRepository;

    public EnrollmentService(
        IGenericRepository<Enrollment> enrollmentRepository)
    {
        _enrollmentRepository = enrollmentRepository;
    }

    public async Task<ApiResponse<PagedResult<EnrollmentResponse>>> GetAllAsync(
        QueryParameters query)
    {
        var enrollments = _enrollmentRepository.GetAll();

        var expand = query.Expand?.ToLower() ?? "";

        if (expand.Contains("student"))
        {
            enrollments = enrollments.Include(x => x.Student);
        }

        if (expand.Contains("course"))
        {
            enrollments = enrollments.Include(x => x.Course);
        }

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            enrollments = enrollments.Where(x =>
                x.Status.Contains(query.Search));
        }

        enrollments = query.Sort switch
        {
            "enrollDate" => enrollments.OrderBy(x => x.EnrollDate),

            "-enrollDate" => enrollments.OrderByDescending(x => x.EnrollDate),

            _ => enrollments.OrderBy(x => x.EnrollmentId)
        };

        var totalItems = await enrollments.CountAsync();

        var data = await enrollments
            .Skip((query.Page - 1) * query.Size)
            .Take(query.Size)
            .ToListAsync();

        var items = data.Select(x => new EnrollmentResponse
        {
            EnrollmentId = x.EnrollmentId,
            StudentId = x.StudentId,
            CourseId = x.CourseId,
            EnrollDate = x.EnrollDate,
            Status = x.Status,

            Student = expand.Contains("student") && x.Student != null
                ? new StudentBriefResponse
                {
                    StudentId = x.Student.StudentId,
                    FullName = x.Student.FullName,
                    Email = x.Student.Email
                }
                : null,

            Course = expand.Contains("course") && x.Course != null
                ? new CourseBriefResponse
                {
                    CourseId = x.Course.CourseId,
                    CourseName = x.Course.CourseName
                }
                : null
        }).ToList();

        var result = new PagedResult<EnrollmentResponse>
        {
            Items = items,

            Pagination = new Pagination
            {
                Page = query.Page,
                PageSize = query.Size,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling(
                    totalItems / (double)query.Size)
            }
        };

        return ApiResponse<PagedResult<EnrollmentResponse>>
            .Ok(result);
    }

    public async Task<ApiResponse<EnrollmentResponse>> GetByIdAsync(int id)
    {
        var enrollment = await _enrollmentRepository
            .GetAll()
            .Include(x => x.Student)
            .Include(x => x.Course)
            .FirstOrDefaultAsync(x => x.EnrollmentId == id);

        if (enrollment == null)
        {
            return ApiResponse<EnrollmentResponse>
                .Fail("Enrollment not found");
        }

        return ApiResponse<EnrollmentResponse>.Ok(
            new EnrollmentResponse
            {
                EnrollmentId = enrollment.EnrollmentId,
                StudentId = enrollment.StudentId,
                CourseId = enrollment.CourseId,
                EnrollDate = enrollment.EnrollDate,
                Status = enrollment.Status,

                Student = new StudentBriefResponse
                {
                    StudentId = enrollment.Student.StudentId,
                    FullName = enrollment.Student.FullName,
                    Email = enrollment.Student.Email
                },

                Course = new CourseBriefResponse
                {
                    CourseId = enrollment.Course.CourseId,
                    CourseName = enrollment.Course.CourseName
                }
            });
    }

    public async Task<ApiResponse<EnrollmentResponse>> CreateAsync(
        EnrollmentCreateRequest request)
    {
        var enrollment = new Enrollment
        {
            StudentId = request.StudentId,
            CourseId = request.CourseId,
            EnrollDate = request.EnrollDate,
            Status = request.Status
        };

        await _enrollmentRepository.AddAsync(enrollment);

        await _enrollmentRepository.SaveChangesAsync();

        return ApiResponse<EnrollmentResponse>.Ok(
            new EnrollmentResponse
            {
                EnrollmentId = enrollment.EnrollmentId,
                StudentId = enrollment.StudentId,
                CourseId = enrollment.CourseId,
                EnrollDate = enrollment.EnrollDate,
                Status = enrollment.Status
            },
            "Enrollment created successfully");
    }

    public async Task<ApiResponse<EnrollmentResponse>> UpdateAsync(
        int id,
        EnrollmentUpdateRequest request)
    {
        var enrollment = await _enrollmentRepository
            .GetByIdAsync(id);

        if (enrollment == null)
        {
            return ApiResponse<EnrollmentResponse>
                .Fail("Enrollment not found");
        }

        enrollment.StudentId = request.StudentId;
        enrollment.CourseId = request.CourseId;
        enrollment.EnrollDate = request.EnrollDate;
        enrollment.Status = request.Status;

        _enrollmentRepository.Update(enrollment);

        await _enrollmentRepository.SaveChangesAsync();

        return ApiResponse<EnrollmentResponse>.Ok(
            new EnrollmentResponse
            {
                EnrollmentId = enrollment.EnrollmentId,
                StudentId = enrollment.StudentId,
                CourseId = enrollment.CourseId,
                EnrollDate = enrollment.EnrollDate,
                Status = enrollment.Status
            },
            "Enrollment updated successfully");
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int id)
    {
        var enrollment = await _enrollmentRepository
            .GetByIdAsync(id);

        if (enrollment == null)
        {
            return ApiResponse<bool>
                .Fail("Enrollment not found");
        }

        _enrollmentRepository.Delete(enrollment);

        await _enrollmentRepository.SaveChangesAsync();

        return ApiResponse<bool>
            .Ok(true, "Enrollment deleted successfully");
    }
}