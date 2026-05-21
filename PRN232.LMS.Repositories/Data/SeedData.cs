using Microsoft.EntityFrameworkCore;
using PRN232.LMS.Repositories.Entities;

namespace PRN232.LMS.Repositories.Data;

public static class SeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var semesters = new List<Semester>();
        for (int i = 1; i <= 5; i++)
        {
            semesters.Add(new Semester
            {
                SemesterId = i,
                SemesterName = $"Semester {i}",
                StartDate = new DateTime(2024, i, 1),
                EndDate = new DateTime(2024, i, 1).AddMonths(3)
            });
        }

        var subjects = new List<Subject>();
        for (int i = 1; i <= 10; i++)
        {
            subjects.Add(new Subject
            {
                SubjectId = i,
                SubjectCode = $"SUB{i:000}",
                SubjectName = $"Subject {i}",
                Credit = i % 3 + 2
            });
        }

        var courses = new List<Course>();
        for (int i = 1; i <= 20; i++)
        {
            courses.Add(new Course
            {
                CourseId = i,
                CourseName = $"Course {i}",
                SemesterId = ((i - 1) % 5) + 1,
                SubjectId = ((i - 1) % 10) + 1
            });
        }

        var students = new List<Student>();
        for (int i = 1; i <= 50; i++)
        {
            students.Add(new Student
            {
                StudentId = i,
                FullName = $"Nguyen Van {i}",
                Email = $"student{i}@gmail.com",
                DateOfBirth = new DateTime(2003, ((i - 1) % 12) + 1, ((i - 1) % 28) + 1)
            });
        }

        var enrollments = new List<Enrollment>();
        for (int i = 1; i <= 500; i++)
        {
            enrollments.Add(new Enrollment
            {
                EnrollmentId = i,
                StudentId = ((i - 1) % 50) + 1,
                CourseId = ((i - 1) % 20) + 1,
                EnrollDate = new DateTime(2024, ((i - 1) % 12) + 1, ((i - 1) % 28) + 1),
                Status = i % 3 == 0 ? "Inactive" : "Active"
            });
        }

        modelBuilder.Entity<Semester>().HasData(semesters);
        modelBuilder.Entity<Subject>().HasData(subjects);
        modelBuilder.Entity<Course>().HasData(courses);
        modelBuilder.Entity<Student>().HasData(students);
        modelBuilder.Entity<Enrollment>().HasData(enrollments);
    }
}