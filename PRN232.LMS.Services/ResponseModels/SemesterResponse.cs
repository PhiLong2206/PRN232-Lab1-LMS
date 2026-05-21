namespace PRN232.LMS.Services.ResponseModels;

public class SemesterResponse
{
    public int SemesterId { get; set; }

    public string SemesterName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}