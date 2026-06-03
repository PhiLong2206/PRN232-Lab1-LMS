using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Interfaces;

public interface IEnrollmentService
{
    Task<ApiResponse<PagedResult<EnrollmentResponse>>> GetAllAsync(QueryParameters query);

    Task<ApiResponse<EnrollmentResponse>> GetByIdAsync(int id);

    Task<ApiResponse<EnrollmentResponse>> CreateAsync(
        EnrollmentCreateRequest request);

    Task<ApiResponse<EnrollmentResponse>> UpdateAsync(
        int id,
        EnrollmentUpdateRequest request);
    Task<ApiResponse<object>> GetByCourseIdAsync(
    int courseId,
    string? expand);

    Task<ApiResponse<bool>> DeleteAsync(int id);
}