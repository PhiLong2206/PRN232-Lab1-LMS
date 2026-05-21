namespace PRN232.LMS.Services.RequestModels;

public class SubjectCreateRequest
{
    public string SubjectCode { get; set; } = null!;
    public string SubjectName { get; set; } = null!;
    public int Credit { get; set; }
}