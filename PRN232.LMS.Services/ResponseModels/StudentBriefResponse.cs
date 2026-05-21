namespace PRN232.LMS.Services.ResponseModels;

public class StudentBriefResponse
{
    public int StudentId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;
}