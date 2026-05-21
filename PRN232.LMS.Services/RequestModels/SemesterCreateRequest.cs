namespace PRN232.LMS.Services.RequestModels;

public class SemesterCreateRequest
{
    public string SemesterName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}