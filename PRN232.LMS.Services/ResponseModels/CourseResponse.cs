namespace PRN232.LMS.Services.ResponseModels;

public class CourseResponse
{
    public int CourseId { get; set; }
    public string CourseName { get; set; } = null!;
    public int SemesterId { get; set; }
    public int SubjectId { get; set; }

    public SemesterBriefResponse? Semester { get; set; }
    public SubjectBriefResponse? Subject { get; set; }
}