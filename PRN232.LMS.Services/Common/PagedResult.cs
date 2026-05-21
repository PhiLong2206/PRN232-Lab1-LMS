namespace PRN232.LMS.Services.Common;

public class PagedResult<T>
{
    public IEnumerable<T> Items { get; set; }
        = new List<T>();

    public Pagination Pagination { get; set; }
        = null!;
}