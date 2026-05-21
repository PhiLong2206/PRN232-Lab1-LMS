namespace PRN232.LMS.Services.Common;

public class PagedResultObject
{
    public IEnumerable<object> Items { get; set; }
        = new List<object>();

    public Pagination Pagination { get; set; }
        = null!;
}