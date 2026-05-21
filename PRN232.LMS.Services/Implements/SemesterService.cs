using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Implements;

public class SemesterService : ISemesterService
{
    private readonly IGenericRepository<Semester> _semesterRepository;

    public SemesterService(
        IGenericRepository<Semester> semesterRepository)
    {
        _semesterRepository = semesterRepository;
    }

    public async Task<ApiResponse<PagedResult<SemesterResponse>>> GetAllAsync(
        QueryParameters query)
    {
        var semesters = _semesterRepository.GetAll();

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            semesters = semesters.Where(x =>
                x.SemesterName.Contains(query.Search));
        }

        var totalItems = await semesters.CountAsync();

        var items = await semesters
            .Skip((query.Page - 1) * query.Size)
            .Take(query.Size)
            .Select(x => new SemesterResponse
            {
                SemesterId = x.SemesterId,
                SemesterName = x.SemesterName,
                StartDate = x.StartDate,
                EndDate = x.EndDate
            })
            .ToListAsync();

        var result = new PagedResult<SemesterResponse>
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

        return ApiResponse<PagedResult<SemesterResponse>>
            .Ok(result);
    }

    public async Task<ApiResponse<SemesterResponse>> GetByIdAsync(int id)
    {
        var semester = await _semesterRepository
            .GetAll()
            .FirstOrDefaultAsync(x => x.SemesterId == id);

        if (semester == null)
        {
            return ApiResponse<SemesterResponse>
                .Fail("Semester not found");
        }

        var response = new SemesterResponse
        {
            SemesterId = semester.SemesterId,
            SemesterName = semester.SemesterName,
            StartDate = semester.StartDate,
            EndDate = semester.EndDate
        };

        return ApiResponse<SemesterResponse>.Ok(response);
    }

    public async Task<ApiResponse<SemesterResponse>> CreateAsync(
        SemesterCreateRequest request)
    {
        var semester = new Semester
        {
            SemesterName = request.SemesterName,
            StartDate = request.StartDate,
            EndDate = request.EndDate
        };

        await _semesterRepository.AddAsync(semester);

        await _semesterRepository.SaveChangesAsync();

        var response = new SemesterResponse
        {
            SemesterId = semester.SemesterId,
            SemesterName = semester.SemesterName,
            StartDate = semester.StartDate,
            EndDate = semester.EndDate
        };

        return ApiResponse<SemesterResponse>
            .Ok(response, "Semester created successfully");
    }

    public async Task<ApiResponse<SemesterResponse>> UpdateAsync(
        int id,
        SemesterUpdateRequest request)
    {
        var semester = await _semesterRepository.GetByIdAsync(id);

        if (semester == null)
        {
            return ApiResponse<SemesterResponse>
                .Fail("Semester not found");
        }

        semester.SemesterName = request.SemesterName;
        semester.StartDate = request.StartDate;
        semester.EndDate = request.EndDate;

        _semesterRepository.Update(semester);

        await _semesterRepository.SaveChangesAsync();

        var response = new SemesterResponse
        {
            SemesterId = semester.SemesterId,
            SemesterName = semester.SemesterName,
            StartDate = semester.StartDate,
            EndDate = semester.EndDate
        };

        return ApiResponse<SemesterResponse>
            .Ok(response, "Semester updated successfully");
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int id)
    {
        var semester = await _semesterRepository.GetByIdAsync(id);

        if (semester == null)
        {
            return ApiResponse<bool>
                .Fail("Semester not found");
        }

        _semesterRepository.Delete(semester);

        await _semesterRepository.SaveChangesAsync();

        return ApiResponse<bool>
            .Ok(true, "Semester deleted successfully");
    }
}