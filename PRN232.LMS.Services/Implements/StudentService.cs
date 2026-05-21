using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

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

        var items = await students
            .Skip((query.Page - 1) * query.Size)
            .Take(query.Size)
            .Select(x => new StudentResponse
            {
                StudentId = x.StudentId,
                FullName = x.FullName,
                Email = x.Email,
                DateOfBirth = x.DateOfBirth
            })
            .ToListAsync();

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

        var response = new StudentResponse
        {
            StudentId = student.StudentId,
            FullName = student.FullName,
            Email = student.Email,
            DateOfBirth = student.DateOfBirth
        };

        return ApiResponse<StudentResponse>.Ok(response);
    }

    public async Task<ApiResponse<StudentResponse>> CreateAsync(
        StudentCreateRequest request)
    {
        var student = new Student
        {
            FullName = request.FullName,
            Email = request.Email,
            DateOfBirth = request.DateOfBirth
        };

        await _studentRepository.AddAsync(student);

        await _studentRepository.SaveChangesAsync();

        var response = new StudentResponse
        {
            StudentId = student.StudentId,
            FullName = student.FullName,
            Email = student.Email,
            DateOfBirth = student.DateOfBirth
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

        student.FullName = request.FullName;
        student.Email = request.Email;
        student.DateOfBirth = request.DateOfBirth;

        _studentRepository.Update(student);

        await _studentRepository.SaveChangesAsync();

        var response = new StudentResponse
        {
            StudentId = student.StudentId,
            FullName = student.FullName,
            Email = student.Email,
            DateOfBirth = student.DateOfBirth
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