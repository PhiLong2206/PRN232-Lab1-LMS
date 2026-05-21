using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Interfaces;

public interface ISubjectService
{
    Task<ApiResponse<PagedResult<SubjectResponse>>> GetAllAsync(QueryParameters query);
    Task<ApiResponse<SubjectResponse>> GetByIdAsync(int id);
    Task<ApiResponse<SubjectResponse>> CreateAsync(SubjectCreateRequest request);
    Task<ApiResponse<SubjectResponse>> UpdateAsync(int id, SubjectUpdateRequest request);
    Task<ApiResponse<bool>> DeleteAsync(int id);
}