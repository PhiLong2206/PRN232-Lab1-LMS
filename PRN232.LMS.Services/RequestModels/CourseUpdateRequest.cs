namespace PRN232.LMS.Services.RequestModels;

public class CourseUpdateRequest
{
    public string CourseName { get; set; } = null!;
    public int SemesterId { get; set; }
    public int SubjectId { get; set; }
}