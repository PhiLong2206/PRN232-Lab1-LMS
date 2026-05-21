using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Interfaces;

public interface ISemesterService
{
    Task<ApiResponse<PagedResult<SemesterResponse>>> GetAllAsync(QueryParameters query);

    Task<ApiResponse<SemesterResponse>> GetByIdAsync(int id);

    Task<ApiResponse<SemesterResponse>> CreateAsync(SemesterCreateRequest request);

    Task<ApiResponse<SemesterResponse>> UpdateAsync(
        int id,
        SemesterUpdateRequest request);

    Task<ApiResponse<bool>> DeleteAsync(int id);
}