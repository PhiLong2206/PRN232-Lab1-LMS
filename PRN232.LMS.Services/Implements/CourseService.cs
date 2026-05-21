using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Implements;

public class CourseService : ICourseService
{
    private readonly IGenericRepository<Course> _courseRepository;
    private readonly IGenericRepository<Semester> _semesterRepository;
    private readonly IGenericRepository<Subject> _subjectRepository;

    public CourseService(
        IGenericRepository<Course> courseRepository,
        IGenericRepository<Semester> semesterRepository,
        IGenericRepository<Subject> subjectRepository)
    {
        _courseRepository = courseRepository;
        _semesterRepository = semesterRepository;
        _subjectRepository = subjectRepository;
    }

    public async Task<ApiResponse<PagedResult<CourseResponse>>> GetAllAsync(QueryParameters query)
    {
        var courses = _courseRepository.GetAll();

        var expand = query.Expand?.ToLower() ?? "";

        if (expand.Contains("semester"))
            courses = courses.Include(x => x.Semester);

        if (expand.Contains("subject"))
            courses = courses.Include(x => x.Subject);

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            courses = courses.Where(x =>
                x.CourseName.Contains(query.Search));
        }

        courses = query.Sort switch
        {
            "courseName" => courses.OrderBy(x => x.CourseName),
            "-courseName" => courses.OrderByDescending(x => x.CourseName),
            "courseId" => courses.OrderBy(x => x.CourseId),
            "-courseId" => courses.OrderByDescending(x => x.CourseId),
            _ => courses.OrderBy(x => x.CourseId)
        };

        var totalItems = await courses.CountAsync();

        var data = await courses
            .Skip((query.Page - 1) * query.Size)
            .Take(query.Size)
            .ToListAsync();

        var items = data.Select(x => new CourseResponse
        {
            CourseId = x.CourseId,
            CourseName = x.CourseName,
            SemesterId = x.SemesterId,
            SubjectId = x.SubjectId,

            Semester = expand.Contains("semester") && x.Semester != null
                ? new SemesterBriefResponse
                {
                    SemesterId = x.Semester.SemesterId,
                    SemesterName = x.Semester.SemesterName
                }
                : null,

            Subject = expand.Contains("subject") && x.Subject != null
                ? new SubjectBriefResponse
                {
                    SubjectId = x.Subject.SubjectId,
                    SubjectCode = x.Subject.SubjectCode,
                    SubjectName = x.Subject.SubjectName
                }
                : null
        }).ToList();

        var result = new PagedResult<CourseResponse>
        {
            Items = items,
            Pagination = new Pagination
            {
                Page = query.Page,
                PageSize = query.Size,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling(totalItems / (double)query.Size)
            }
        };

        return ApiResponse<PagedResult<CourseResponse>>.Ok(result);
    }

    public async Task<ApiResponse<CourseResponse>> GetByIdAsync(int id)
    {
        var course = await _courseRepository.GetAll()
            .Include(x => x.Semester)
            .Include(x => x.Subject)
            .FirstOrDefaultAsync(x => x.CourseId == id);

        if (course == null)
            return ApiResponse<CourseResponse>.Fail("Course not found");

        return ApiResponse<CourseResponse>.Ok(new CourseResponse
        {
            CourseId = course.CourseId,
            CourseName = course.CourseName,
            SemesterId = course.SemesterId,
            SubjectId = course.SubjectId,
            Semester = new SemesterBriefResponse
            {
                SemesterId = course.Semester.SemesterId,
                SemesterName = course.Semester.SemesterName
            },
            Subject = new SubjectBriefResponse
            {
                SubjectId = course.Subject.SubjectId,
                SubjectCode = course.Subject.SubjectCode,
                SubjectName = course.Subject.SubjectName
            }
        });
    }

    public async Task<ApiResponse<CourseResponse>> CreateAsync(CourseCreateRequest request)
    {
        var semesterExists = await _semesterRepository.GetAll()
            .AnyAsync(x => x.SemesterId == request.SemesterId);

        var subjectExists = await _subjectRepository.GetAll()
            .AnyAsync(x => x.SubjectId == request.SubjectId);

        if (!semesterExists)
            return ApiResponse<CourseResponse>.Fail("Semester not found");

        if (!subjectExists)
            return ApiResponse<CourseResponse>.Fail("Subject not found");

        var course = new Course
        {
            CourseName = request.CourseName,
            SemesterId = request.SemesterId,
            SubjectId = request.SubjectId
        };

        await _courseRepository.AddAsync(course);
        await _courseRepository.SaveChangesAsync();

        return ApiResponse<CourseResponse>.Ok(new CourseResponse
        {
            CourseId = course.CourseId,
            CourseName = course.CourseName,
            SemesterId = course.SemesterId,
            SubjectId = course.SubjectId
        }, "Course created successfully");
    }

    public async Task<ApiResponse<CourseResponse>> UpdateAsync(int id, CourseUpdateRequest request)
    {
        var course = await _courseRepository.GetByIdAsync(id);

        if (course == null)
            return ApiResponse<CourseResponse>.Fail("Course not found");

        var semesterExists = await _semesterRepository.GetAll()
            .AnyAsync(x => x.SemesterId == request.SemesterId);

        var subjectExists = await _subjectRepository.GetAll()
            .AnyAsync(x => x.SubjectId == request.SubjectId);

        if (!semesterExists)
            return ApiResponse<CourseResponse>.Fail("Semester not found");

        if (!subjectExists)
            return ApiResponse<CourseResponse>.Fail("Subject not found");

        course.CourseName = request.CourseName;
        course.SemesterId = request.SemesterId;
        course.SubjectId = request.SubjectId;

        _courseRepository.Update(course);
        await _courseRepository.SaveChangesAsync();

        return ApiResponse<CourseResponse>.Ok(new CourseResponse
        {
            CourseId = course.CourseId,
            CourseName = course.CourseName,
            SemesterId = course.SemesterId,
            SubjectId = course.SubjectId
        }, "Course updated successfully");
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int id)
    {
        var course = await _courseRepository.GetByIdAsync(id);

        if (course == null)
            return ApiResponse<bool>.Fail("Course not found");

        _courseRepository.Delete(course);
        await _courseRepository.SaveChangesAsync();

        return ApiResponse<bool>.Ok(true, "Course deleted successfully");
    }
}