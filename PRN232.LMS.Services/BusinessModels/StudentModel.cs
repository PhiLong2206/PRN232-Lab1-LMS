using PRN232.LMS.Repositories.Entities;

namespace PRN232.LMS.Services.BusinessModels;

public class StudentModel
{
    public int StudentId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}