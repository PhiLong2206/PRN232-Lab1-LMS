using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.RequestModels;
using PRN232.LMS.Services.ResponseModels;

namespace PRN232.LMS.Services.Interfaces;

public interface IStudentService
{
    Task<ApiResponse<PagedResultObject>> GetAllAsync(QueryParameters query);

    Task<ApiResponse<StudentResponse>> GetByIdAsync(int id);

    Task<ApiResponse<StudentResponse>> CreateAsync(StudentCreateRequest request);

    Task<ApiResponse<StudentResponse>> UpdateAsync(
        int id,
        StudentUpdateRequest request);

    Task<ApiResponse<bool>> DeleteAsync(int id);
}