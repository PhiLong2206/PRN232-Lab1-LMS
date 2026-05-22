using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;
using PRN232.LMS.Services.BusinessModels;

namespace PRN232.LMS.Services.Implements;

public class StudentService : IStudentService
{
    private readonly IGenericRepository<Student> _studentRepository;

    public StudentService(
        IGenericRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<ApiResponse<PagedResultObject>> GetAllAsync(
    QueryParameters query)
    {
        var students = _studentRepository.GetAll();

        // Search
        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            students = students.Where(x =>
                x.FullName.Contains(query.Search) ||
                x.Email.Contains(query.Search));
        }

        // Sort
        students = query.Sort switch
        {
            "fullName" => students.OrderBy(x => x.FullName),

            "-fullName" => students.OrderByDescending(x => x.FullName),

            "dateOfBirth" => students.OrderBy(x => x.DateOfBirth),

            "-dateOfBirth" => students.OrderByDescending(x => x.DateOfBirth),

            _ => students.OrderBy(x => x.StudentId)
        };

        // Paging
        var totalItems = await students.CountAsync();

        var studentEntities = await students
    .Skip((query.Page - 1) * query.Size)
    .Take(query.Size)
    .ToListAsync();


        // Entity -> BusinessModel
        var studentModels = studentEntities
            .Select(x => new StudentModel
            {
                StudentId = x.StudentId,
                FullName = x.FullName,
                Email = x.Email,
                DateOfBirth = x.DateOfBirth
            })
            .ToList();


        // BusinessModel -> ResponseModel
        var items = studentModels
            .Select(x => new StudentResponse
            {
                StudentId = x.StudentId,
                FullName = x.FullName,
                Email = x.Email,
                DateOfBirth = x.DateOfBirth
            })
            .ToList();

        var result = new PagedResultObject
        {
            Items = FieldSelector.SelectFields<StudentResponse>(items, query.Fields),

            Pagination = new Pagination
            {
                Page = query.Page,
                PageSize = query.Size,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling(
             totalItems / (double)query.Size)
            }
        };

        return ApiResponse<PagedResultObject>
            .Ok(result);
    }

    public async Task<ApiResponse<StudentResponse>> GetByIdAsync(int id)
    {
        var student = await _studentRepository
            .GetAll()
            .FirstOrDefaultAsync(x => x.StudentId == id);

        if (student == null)
        {
            return ApiResponse<StudentResponse>
                .Fail("Student not found");
        }
        // Entity -> BusinessModel
        var model = new StudentModel
        {
            StudentId = student.StudentId,
            FullName = student.FullName,
            Email = student.Email,
            DateOfBirth = student.DateOfBirth
        };

        // BusinessModel -> ResponseModel
        var response = new StudentResponse
        {
            StudentId = model.StudentId,
            FullName = model.FullName,
            Email = model.Email,
            DateOfBirth = model.DateOfBirth
        };

        return ApiResponse<StudentResponse>.Ok(response);
    }

    public async Task<ApiResponse<StudentResponse>> CreateAsync(
        StudentCreateRequest request)
    {
        // RequestModel -> BusinessModel
        var model = new StudentModel
        {
            FullName = request.FullName,
            Email = request.Email,
            DateOfBirth = request.DateOfBirth
        };

        // BusinessModel -> Entity
        var student = new Student
        {
            FullName = model.FullName,
            Email = model.Email,
            DateOfBirth = model.DateOfBirth
        };

        await _studentRepository.AddAsync(student);

        await _studentRepository.SaveChangesAsync();

        // Entity -> BusinessModel
        model.StudentId = student.StudentId;

        // BusinessModel -> ResponseModel
        var response = new StudentResponse
        {
            StudentId = model.StudentId,
            FullName = model.FullName,
            Email = model.Email,
            DateOfBirth = model.DateOfBirth
        };

        return ApiResponse<StudentResponse>
            .Ok(response, "Student created successfully");
    }

    public async Task<ApiResponse<StudentResponse>> UpdateAsync(
        int id,
        StudentUpdateRequest request)
    {
        var student = await _studentRepository.GetByIdAsync(id);

        if (student == null)
        {
            return ApiResponse<StudentResponse>
                .Fail("Student not found");
        }

        // RequestModel -> BusinessModel
        var model = new StudentModel
        {
            StudentId = id,
            FullName = request.FullName,
            Email = request.Email,
            DateOfBirth = request.DateOfBirth
        };

        // BusinessModel -> Entity
        student.FullName = model.FullName;
        student.Email = model.Email;
        student.DateOfBirth = model.DateOfBirth;

        _studentRepository.Update(student);

        await _studentRepository.SaveChangesAsync();

        var response = new StudentResponse
        {
            StudentId = model.StudentId,
            FullName = model.FullName,
            Email = model.Email,
            DateOfBirth = model.DateOfBirth
        };

        return ApiResponse<StudentResponse>
            .Ok(response, "Student updated successfully");
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int id)
    {
        var student = await _studentRepository.GetByIdAsync(id);

        if (student == null)
        {
            return ApiResponse<bool>
                .Fail("Student not found");
        }

        _studentRepository.Delete(student);

        await _studentRepository.SaveChangesAsync();

        return ApiResponse<bool>
            .Ok(true, "Student deleted successfully");
    }
}