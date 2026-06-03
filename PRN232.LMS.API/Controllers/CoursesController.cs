using Microsoft.AspNetCore.Mvc;
using PRN232.LMS.Services.Common;
using PRN232.LMS.Services.Interfaces;
using PRN232.LMS.Services.RequestModels;

namespace PRN232.LMS.API.Controllers;

[Route("api/courses")]
[ApiController]
public class CoursesController : ControllerBase
{
    private readonly ICourseService _courseService;
    private readonly IEnrollmentService _enrollmentService;

    public CoursesController(
        ICourseService courseService,
        IEnrollmentService enrollmentService)
    {
        _courseService = courseService;
        _enrollmentService = enrollmentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(
        [FromQuery] QueryParameters query)
    {
        return Ok(await _courseService.GetAllAsync(query));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _courseService.GetByIdAsync(id);

        if (!result.Success)
            return NotFound(result);

        return Ok(result);
    }

    [HttpGet("{id}/enrollments")]
    public async Task<IActionResult> GetEnrollmentsByCourse(
        int id,
        [FromQuery] string? expand = null)
    {
        var result = await _enrollmentService
            .GetByCourseIdAsync(id, expand);

        if (!result.Success)
            return NotFound(result);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        CourseCreateRequest request)
    {
        var result = await _courseService.CreateAsync(request);

        if (!result.Success)
            return BadRequest(result);

        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Data!.CourseId },
            result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        int id,
        CourseUpdateRequest request)
    {
        var result = await _courseService
            .UpdateAsync(id, request);

        if (!result.Success)
            return BadRequest(result);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _courseService.DeleteAsync(id);

        if (!result.Success)
            return NotFound(result);

        return Ok(result);
    }
}