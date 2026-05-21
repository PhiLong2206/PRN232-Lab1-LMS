using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Interfaces;

public interface ICourseService
{
    Task<ApiResponse<PagedResult<CourseResponse>>> GetAllAsync(QueryParameters query);
    Task<ApiResponse<CourseResponse>> GetByIdAsync(int id);
    Task<ApiResponse<CourseResponse>> CreateAsync(CourseCreateRequest request);
    Task<ApiResponse<CourseResponse>> UpdateAsync(int id, CourseUpdateRequest request);
    Task<ApiResponse<bool>> DeleteAsync(int id);
}