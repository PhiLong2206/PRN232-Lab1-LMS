using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;
using PRN232.LMS.Repositories.Generic;
using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Implements;

public class SubjectService : ISubjectService
{
    private readonly IGenericRepository<Subject> _subjectRepository;

    public SubjectService(IGenericRepository<Subject> subjectRepository)
    {
        _subjectRepository = subjectRepository;
    }

    public async Task<ApiResponse<PagedResult<SubjectResponse>>> GetAllAsync(QueryParameters query)
    {
        var subjects = _subjectRepository.GetAll();

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            subjects = subjects.Where(x =>
                x.SubjectCode.Contains(query.Search) ||
                x.SubjectName.Contains(query.Search));
        }

        subjects = query.Sort switch
        {
            "subjectCode" => subjects.OrderBy(x => x.SubjectCode),
            "-subjectCode" => subjects.OrderByDescending(x => x.SubjectCode),
            "subjectName" => subjects.OrderBy(x => x.SubjectName),
            "-subjectName" => subjects.OrderByDescending(x => x.SubjectName),
            "credit" => subjects.OrderBy(x => x.Credit),
            "-credit" => subjects.OrderByDescending(x => x.Credit),
            _ => subjects.OrderBy(x => x.SubjectId)
        };

        var totalItems = await subjects.CountAsync();

        var items = await subjects
            .Skip((query.Page - 1) * query.Size)
            .Take(query.Size)
            .Select(x => new SubjectResponse
            {
                SubjectId = x.SubjectId,
                SubjectCode = x.SubjectCode,
                SubjectName = x.SubjectName,
                Credit = x.Credit
            })
            .ToListAsync();

        var result = new PagedResult<SubjectResponse>
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

        return ApiResponse<PagedResult<SubjectResponse>>.Ok(result);
    }

    public async Task<ApiResponse<SubjectResponse>> GetByIdAsync(int id)
    {
        var subject = await _subjectRepository.GetAll()
            .FirstOrDefaultAsync(x => x.SubjectId == id);

        if (subject == null)
            return ApiResponse<SubjectResponse>.Fail("Subject not found");

        return ApiResponse<SubjectResponse>.Ok(new SubjectResponse
        {
            SubjectId = subject.SubjectId,
            SubjectCode = subject.SubjectCode,
            SubjectName = subject.SubjectName,
            Credit = subject.Credit
        });
    }

    public async Task<ApiResponse<SubjectResponse>> CreateAsync(SubjectCreateRequest request)
    {
        var subject = new Subject
        {
            SubjectCode = request.SubjectCode,
            SubjectName = request.SubjectName,
            Credit = request.Credit
        };

        await _subjectRepository.AddAsync(subject);
        await _subjectRepository.SaveChangesAsync();

        return ApiResponse<SubjectResponse>.Ok(new SubjectResponse
        {
            SubjectId = subject.SubjectId,
            SubjectCode = subject.SubjectCode,
            SubjectName = subject.SubjectName,
            Credit = subject.Credit
        }, "Subject created successfully");
    }

    public async Task<ApiResponse<SubjectResponse>> UpdateAsync(int id, SubjectUpdateRequest request)
    {
        var subject = await _subjectRepository.GetByIdAsync(id);

        if (subject == null)
            return ApiResponse<SubjectResponse>.Fail("Subject not found");

        subject.SubjectCode = request.SubjectCode;
        subject.SubjectName = request.SubjectName;
        subject.Credit = request.Credit;

        _subjectRepository.Update(subject);
        await _subjectRepository.SaveChangesAsync();

        return ApiResponse<SubjectResponse>.Ok(new SubjectResponse
        {
            SubjectId = subject.SubjectId,
            SubjectCode = subject.SubjectCode,
            SubjectName = subject.SubjectName,
            Credit = subject.Credit
        }, "Subject updated successfully");
    }

    public async Task<ApiResponse<bool>> DeleteAsync(int id)
    {
        var subject = await _subjectRepository.GetByIdAsync(id);

        if (subject == null)
            return ApiResponse<bool>.Fail("Subject not found");

        _subjectRepository.Delete(subject);
        await _subjectRepository.SaveChangesAsync();

        return ApiResponse<bool>.Ok(true, "Subject deleted successfully");
    }
}