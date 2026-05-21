namespace PRN232.LMS.Services.RequestModels;

public class EnrollmentCreateRequest
{
    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public DateTime EnrollDate { get; set; }

    public string Status { get; set; } = null!;
}