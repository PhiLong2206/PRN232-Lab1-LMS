using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.BusinessModels;
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

        var enrollmentEntities = await enrollments
            .Skip((query.Page - 1) * query.Size)
            .Take(query.Size)
            .ToListAsync();

        // Entity -> BusinessModel
        var enrollmentModels = enrollmentEntities
            .Select(x => new EnrollmentModel
            {
                EnrollmentId = x.EnrollmentId,
                StudentId = x.StudentId,
                CourseId = x.CourseId,
                EnrollDate = x.EnrollDate,
                Status = x.Status,

                Student = expand.Contains("student") && x.Student != null
                    ? new StudentModel
                    {
                        StudentId = x.Student.StudentId,
                        FullName = x.Student.FullName,
                        Email = x.Student.Email,
                        DateOfBirth = x.Student.DateOfBirth
                    }
                    : null,

                Course = expand.Contains("course") && x.Course != null
                    ? new CourseModel
                    {
                        CourseId = x.Course.CourseId,
                        CourseName = x.Course.CourseName,
                        SemesterId = x.Course.SemesterId,
                        SubjectId = x.Course.SubjectId
                    }
                    : null
            })
            .ToList();

        // BusinessModel -> ResponseModel
        var items = enrollmentModels
            .Select(x => new EnrollmentResponse
            {
                EnrollmentId = x.EnrollmentId,
                StudentId = x.StudentId,
                CourseId = x.CourseId,
                EnrollDate = x.EnrollDate,
                Status = x.Status,

                Student = x.Student == null
                    ? null
                    : new StudentBriefResponse
                    {
                        StudentId = x.Student.StudentId,
                        FullName = x.Student.FullName,
                        Email = x.Student.Email
                    },

                Course = x.Course == null
                    ? null
                    : new CourseBriefResponse
                    {
                        CourseId = x.Course.CourseId,
                        CourseName = x.Course.CourseName
                    }
            })
            .ToList();

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

        // Entity -> BusinessModel
        var model = new EnrollmentModel
        {
            EnrollmentId = enrollment.EnrollmentId,
            StudentId = enrollment.StudentId,
            CourseId = enrollment.CourseId,
            EnrollDate = enrollment.EnrollDate,
            Status = enrollment.Status,

            Student = new StudentModel
            {
                StudentId = enrollment.Student.StudentId,
                FullName = enrollment.Student.FullName,
                Email = enrollment.Student.Email,
                DateOfBirth = enrollment.Student.DateOfBirth
            },

            Course = new CourseModel
            {
                CourseId = enrollment.Course.CourseId,
                CourseName = enrollment.Course.CourseName,
                SemesterId = enrollment.Course.SemesterId,
                SubjectId = enrollment.Course.SubjectId
            }
        };

        // BusinessModel -> ResponseModel
        var response = new EnrollmentResponse
        {
            EnrollmentId = model.EnrollmentId,
            StudentId = model.StudentId,
            CourseId = model.CourseId,
            EnrollDate = model.EnrollDate,
            Status = model.Status,

            Student = new StudentBriefResponse
            {
                StudentId = model.Student.StudentId,
                FullName = model.Student.FullName,
                Email = model.Student.Email
            },

            Course = new CourseBriefResponse
            {
                CourseId = model.Course.CourseId,
                CourseName = model.Course.CourseName
            }
        };

        return ApiResponse<EnrollmentResponse>.Ok(response);
    }

    public async Task<ApiResponse<EnrollmentResponse>> CreateAsync(
        EnrollmentCreateRequest request)
    {
        // RequestModel -> BusinessModel
        var model = new EnrollmentModel
        {
            StudentId = request.StudentId,
            CourseId = request.CourseId,
            EnrollDate = request.EnrollDate,
            Status = request.Status
        };

        // BusinessModel -> Entity
        var enrollment = new Enrollment
        {
            StudentId = model.StudentId,
            CourseId = model.CourseId,
            EnrollDate = model.EnrollDate,
            Status = model.Status
        };

        await _enrollmentRepository.AddAsync(enrollment);

        await _enrollmentRepository.SaveChangesAsync();

        model.EnrollmentId = enrollment.EnrollmentId;

        // BusinessModel -> ResponseModel
        var response = new EnrollmentResponse
        {
            EnrollmentId = model.EnrollmentId,
            StudentId = model.StudentId,
            CourseId = model.CourseId,
            EnrollDate = model.EnrollDate,
            Status = model.Status
        };

        return ApiResponse<EnrollmentResponse>.Ok(
            response,
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

        // RequestModel -> BusinessModel
        var model = new EnrollmentModel
        {
            EnrollmentId = id,
            StudentId = request.StudentId,
            CourseId = request.CourseId,
            EnrollDate = request.EnrollDate,
            Status = request.Status
        };

        // BusinessModel -> Entity
        enrollment.StudentId = model.StudentId;
        enrollment.CourseId = model.CourseId;
        enrollment.EnrollDate = model.EnrollDate;
        enrollment.Status = model.Status;

        _enrollmentRepository.Update(enrollment);

        await _enrollmentRepository.SaveChangesAsync();

        // BusinessModel -> ResponseModel
        var response = new EnrollmentResponse
        {
            EnrollmentId = model.EnrollmentId,
            StudentId = model.StudentId,
            CourseId = model.CourseId,
            EnrollDate = model.EnrollDate,
            Status = model.Status
        };

        return ApiResponse<EnrollmentResponse>.Ok(
            response,
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