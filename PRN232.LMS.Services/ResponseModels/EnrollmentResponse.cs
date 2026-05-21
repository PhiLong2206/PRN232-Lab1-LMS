namespace PRN232.LMS.Services.ResponseModels;

public class EnrollmentResponse
{
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public DateTime EnrollDate { get; set; }

    public string Status { get; set; } = null!;

    public StudentBriefResponse? Student { get; set; }

    public CourseBriefResponse? Course { get; set; }
}