namespace PRN232.LMS.Services.ResponseModels;

public class SubjectBriefResponse
{
    public int SubjectId { get; set; }
    public string SubjectCode { get; set; } = null!;
    public string SubjectName { get; set; } = null!;
}