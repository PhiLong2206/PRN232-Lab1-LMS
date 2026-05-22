using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.BusinessModels;
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

        var semesterEntities = await semesters
            .Skip((query.Page - 1) * query.Size)
            .Take(query.Size)
            .ToListAsync();

        // Entity -> BusinessModel
        var semesterModels = semesterEntities
            .Select(x => new SemesterModel
            {
                SemesterId = x.SemesterId,
                SemesterName = x.SemesterName,
                StartDate = x.StartDate,
                EndDate = x.EndDate
            })
            .ToList();

        // BusinessModel -> ResponseModel
        var items = semesterModels
            .Select(x => new SemesterResponse
            {
                SemesterId = x.SemesterId,
                SemesterName = x.SemesterName,
                StartDate = x.StartDate,
                EndDate = x.EndDate
            })
            .ToList();

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

        // Entity -> BusinessModel
        var model = new SemesterModel
        {
            SemesterId = semester.SemesterId,
            SemesterName = semester.SemesterName,
            StartDate = semester.StartDate,
            EndDate = semester.EndDate
        };

        // BusinessModel -> ResponseModel
        var response = new SemesterResponse
        {
            SemesterId = model.SemesterId,
            SemesterName = model.SemesterName,
            StartDate = model.StartDate,
            EndDate = model.EndDate
        };

        return ApiResponse<SemesterResponse>.Ok(response);
    }

    public async Task<ApiResponse<SemesterResponse>> CreateAsync(
        SemesterCreateRequest request)
    {
        // RequestModel -> BusinessModel
        var model = new SemesterModel
        {
            SemesterName = request.SemesterName,
            StartDate = request.StartDate,
            EndDate = request.EndDate
        };

        // BusinessModel -> Entity
        var semester = new Semester
        {
            SemesterName = model.SemesterName,
            StartDate = model.StartDate,
            EndDate = model.EndDate
        };

        await _semesterRepository.AddAsync(semester);

        await _semesterRepository.SaveChangesAsync();

        model.SemesterId = semester.SemesterId;

        // BusinessModel -> ResponseModel
        var response = new SemesterResponse
        {
            SemesterId = model.SemesterId,
            SemesterName = model.SemesterName,
            StartDate = model.StartDate,
            EndDate = model.EndDate
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

        // RequestModel -> BusinessModel
        var model = new SemesterModel
        {
            SemesterId = id,
            SemesterName = request.SemesterName,
            StartDate = request.StartDate,
            EndDate = request.EndDate
        };

        // BusinessModel -> Entity
        semester.SemesterName = model.SemesterName;
        semester.StartDate = model.StartDate;
        semester.EndDate = model.EndDate;

        _semesterRepository.Update(semester);

        await _semesterRepository.SaveChangesAsync();

        // BusinessModel -> ResponseModel
        var response = new SemesterResponse
        {
            SemesterId = model.SemesterId,
            SemesterName = model.SemesterName,
            StartDate = model.StartDate,
            EndDate = model.EndDate
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