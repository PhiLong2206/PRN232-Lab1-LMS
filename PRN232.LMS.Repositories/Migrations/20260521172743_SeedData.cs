using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRN232.LMS.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "SemesterId", "EndDate", "SemesterName", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Semester 1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Semester 2", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Semester 3", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Semester 4", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Semester 5", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "FullName" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "student1@gmail.com", "Nguyen Van 1" },
                    { 2, new DateTime(2003, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "student2@gmail.com", "Nguyen Van 2" },
                    { 3, new DateTime(2003, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "student3@gmail.com", "Nguyen Van 3" },
                    { 4, new DateTime(2003, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "student4@gmail.com", "Nguyen Van 4" },
                    { 5, new DateTime(2003, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "student5@gmail.com", "Nguyen Van 5" },
                    { 6, new DateTime(2003, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "student6@gmail.com", "Nguyen Van 6" },
                    { 7, new DateTime(2003, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "student7@gmail.com", "Nguyen Van 7" },
                    { 8, new DateTime(2003, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "student8@gmail.com", "Nguyen Van 8" },
                    { 9, new DateTime(2003, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "student9@gmail.com", "Nguyen Van 9" },
                    { 10, new DateTime(2003, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "student10@gmail.com", "Nguyen Van 10" },
                    { 11, new DateTime(2003, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "student11@gmail.com", "Nguyen Van 11" },
                    { 12, new DateTime(2003, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "student12@gmail.com", "Nguyen Van 12" },
                    { 13, new DateTime(2003, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "student13@gmail.com", "Nguyen Van 13" },
                    { 14, new DateTime(2003, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "student14@gmail.com", "Nguyen Van 14" },
                    { 15, new DateTime(2003, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "student15@gmail.com", "Nguyen Van 15" },
                    { 16, new DateTime(2003, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "student16@gmail.com", "Nguyen Van 16" },
                    { 17, new DateTime(2003, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "student17@gmail.com", "Nguyen Van 17" },
                    { 18, new DateTime(2003, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "student18@gmail.com", "Nguyen Van 18" },
                    { 19, new DateTime(2003, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "student19@gmail.com", "Nguyen Van 19" },
                    { 20, new DateTime(2003, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "student20@gmail.com", "Nguyen Van 20" },
                    { 21, new DateTime(2003, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "student21@gmail.com", "Nguyen Van 21" },
                    { 22, new DateTime(2003, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "student22@gmail.com", "Nguyen Van 22" },
                    { 23, new DateTime(2003, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "student23@gmail.com", "Nguyen Van 23" },
                    { 24, new DateTime(2003, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "student24@gmail.com", "Nguyen Van 24" },
                    { 25, new DateTime(2003, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "student25@gmail.com", "Nguyen Van 25" },
                    { 26, new DateTime(2003, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "student26@gmail.com", "Nguyen Van 26" },
                    { 27, new DateTime(2003, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "student27@gmail.com", "Nguyen Van 27" },
                    { 28, new DateTime(2003, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "student28@gmail.com", "Nguyen Van 28" },
                    { 29, new DateTime(2003, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "student29@gmail.com", "Nguyen Van 29" },
                    { 30, new DateTime(2003, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "student30@gmail.com", "Nguyen Van 30" },
                    { 31, new DateTime(2003, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "student31@gmail.com", "Nguyen Van 31" },
                    { 32, new DateTime(2003, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "student32@gmail.com", "Nguyen Van 32" },
                    { 33, new DateTime(2003, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "student33@gmail.com", "Nguyen Van 33" },
                    { 34, new DateTime(2003, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "student34@gmail.com", "Nguyen Van 34" },
                    { 35, new DateTime(2003, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "student35@gmail.com", "Nguyen Van 35" },
                    { 36, new DateTime(2003, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "student36@gmail.com", "Nguyen Van 36" },
                    { 37, new DateTime(2003, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "student37@gmail.com", "Nguyen Van 37" },
                    { 38, new DateTime(2003, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "student38@gmail.com", "Nguyen Van 38" },
                    { 39, new DateTime(2003, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "student39@gmail.com", "Nguyen Van 39" },
                    { 40, new DateTime(2003, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "student40@gmail.com", "Nguyen Van 40" },
                    { 41, new DateTime(2003, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "student41@gmail.com", "Nguyen Van 41" },
                    { 42, new DateTime(2003, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "student42@gmail.com", "Nguyen Van 42" },
                    { 43, new DateTime(2003, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "student43@gmail.com", "Nguyen Van 43" },
                    { 44, new DateTime(2003, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "student44@gmail.com", "Nguyen Van 44" },
                    { 45, new DateTime(2003, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "student45@gmail.com", "Nguyen Van 45" },
                    { 46, new DateTime(2003, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "student46@gmail.com", "Nguyen Van 46" },
                    { 47, new DateTime(2003, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "student47@gmail.com", "Nguyen Van 47" },
                    { 48, new DateTime(2003, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "student48@gmail.com", "Nguyen Van 48" },
                    { 49, new DateTime(2003, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "student49@gmail.com", "Nguyen Van 49" },
                    { 50, new DateTime(2003, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "student50@gmail.com", "Nguyen Van 50" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Credit", "SubjectCode", "SubjectName" },
                values: new object[,]
                {
                    { 1, 3, "SUB001", "Subject 1" },
                    { 2, 4, "SUB002", "Subject 2" },
                    { 3, 2, "SUB003", "Subject 3" },
                    { 4, 3, "SUB004", "Subject 4" },
                    { 5, 4, "SUB005", "Subject 5" },
                    { 6, 2, "SUB006", "Subject 6" },
                    { 7, 3, "SUB007", "Subject 7" },
                    { 8, 4, "SUB008", "Subject 8" },
                    { 9, 2, "SUB009", "Subject 9" },
                    { 10, 3, "SUB010", "Subject 10" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "SemesterId", "SubjectId" },
                values: new object[,]
                {
                    { 1, "Course 1", 1, 1 },
                    { 2, "Course 2", 2, 2 },
                    { 3, "Course 3", 3, 3 },
                    { 4, "Course 4", 4, 4 },
                    { 5, "Course 5", 5, 5 },
                    { 6, "Course 6", 1, 6 },
                    { 7, "Course 7", 2, 7 },
                    { 8, "Course 8", 3, 8 },
                    { 9, "Course 9", 4, 9 },
                    { 10, "Course 10", 5, 10 },
                    { 11, "Course 11", 1, 1 },
                    { 12, "Course 12", 2, 2 },
                    { 13, "Course 13", 3, 3 },
                    { 14, "Course 14", 4, 4 },
                    { 15, "Course 15", 5, 5 },
                    { 16, "Course 16", 1, 6 },
                    { 17, "Course 17", 2, 7 },
                    { 18, "Course 18", 3, 8 },
                    { 19, "Course 19", 4, 9 },
                    { 20, "Course 20", 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "EnrollDate", "Status", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 1 },
                    { 2, 2, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 2 },
                    { 3, 3, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 3 },
                    { 4, 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 4 },
                    { 5, 5, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 5 },
                    { 6, 6, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 6 },
                    { 7, 7, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 7 },
                    { 8, 8, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 8 },
                    { 9, 9, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 9 },
                    { 10, 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 10 },
                    { 11, 11, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 11 },
                    { 12, 12, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 12 },
                    { 13, 13, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 13 },
                    { 14, 14, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 14 },
                    { 15, 15, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 15 },
                    { 16, 16, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 16 },
                    { 17, 17, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 17 },
                    { 18, 18, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 18 },
                    { 19, 19, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 19 },
                    { 20, 20, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 20 },
                    { 21, 1, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 21 },
                    { 22, 2, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 22 },
                    { 23, 3, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 23 },
                    { 24, 4, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 24 },
                    { 25, 5, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 25 },
                    { 26, 6, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 26 },
                    { 27, 7, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 27 },
                    { 28, 8, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 28 },
                    { 29, 9, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 29 },
                    { 30, 10, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 30 },
                    { 31, 11, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 31 },
                    { 32, 12, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 32 },
                    { 33, 13, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 33 },
                    { 34, 14, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 34 },
                    { 35, 15, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 35 },
                    { 36, 16, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 36 },
                    { 37, 17, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 37 },
                    { 38, 18, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 38 },
                    { 39, 19, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 39 },
                    { 40, 20, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 40 },
                    { 41, 1, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 41 },
                    { 42, 2, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 42 },
                    { 43, 3, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 43 },
                    { 44, 4, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 44 },
                    { 45, 5, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 45 },
                    { 46, 6, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 46 },
                    { 47, 7, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 47 },
                    { 48, 8, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 48 },
                    { 49, 9, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 49 },
                    { 50, 10, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 50 },
                    { 51, 11, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 1 },
                    { 52, 12, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 2 },
                    { 53, 13, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 3 },
                    { 54, 14, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 4 },
                    { 55, 15, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 5 },
                    { 56, 16, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 6 },
                    { 57, 17, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 7 },
                    { 58, 18, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 8 },
                    { 59, 19, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 9 },
                    { 60, 20, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 10 },
                    { 61, 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 11 },
                    { 62, 2, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 12 },
                    { 63, 3, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 13 },
                    { 64, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 14 },
                    { 65, 5, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 15 },
                    { 66, 6, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 16 },
                    { 67, 7, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 17 },
                    { 68, 8, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 18 },
                    { 69, 9, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 19 },
                    { 70, 10, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 20 },
                    { 71, 11, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 21 },
                    { 72, 12, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 22 },
                    { 73, 13, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 23 },
                    { 74, 14, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 24 },
                    { 75, 15, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 25 },
                    { 76, 16, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 26 },
                    { 77, 17, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 27 },
                    { 78, 18, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 28 },
                    { 79, 19, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 29 },
                    { 80, 20, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 30 },
                    { 81, 1, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 31 },
                    { 82, 2, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 32 },
                    { 83, 3, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 33 },
                    { 84, 4, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 34 },
                    { 85, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 35 },
                    { 86, 6, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 36 },
                    { 87, 7, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 37 },
                    { 88, 8, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 38 },
                    { 89, 9, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 39 },
                    { 90, 10, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 40 },
                    { 91, 11, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 41 },
                    { 92, 12, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 42 },
                    { 93, 13, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 43 },
                    { 94, 14, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 44 },
                    { 95, 15, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 45 },
                    { 96, 16, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 46 },
                    { 97, 17, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 47 },
                    { 98, 18, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 48 },
                    { 99, 19, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 49 },
                    { 100, 20, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 50 },
                    { 101, 1, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 1 },
                    { 102, 2, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 2 },
                    { 103, 3, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 3 },
                    { 104, 4, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 4 },
                    { 105, 5, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 5 },
                    { 106, 6, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 6 },
                    { 107, 7, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 7 },
                    { 108, 8, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 8 },
                    { 109, 9, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 9 },
                    { 110, 10, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 10 },
                    { 111, 11, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 11 },
                    { 112, 12, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 12 },
                    { 113, 13, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 13 },
                    { 114, 14, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 14 },
                    { 115, 15, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 15 },
                    { 116, 16, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 16 },
                    { 117, 17, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 17 },
                    { 118, 18, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 18 },
                    { 119, 19, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 19 },
                    { 120, 20, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 20 },
                    { 121, 1, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 21 },
                    { 122, 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 22 },
                    { 123, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 23 },
                    { 124, 4, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 24 },
                    { 125, 5, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 25 },
                    { 126, 6, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 26 },
                    { 127, 7, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 27 },
                    { 128, 8, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 28 },
                    { 129, 9, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 29 },
                    { 130, 10, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 30 },
                    { 131, 11, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 31 },
                    { 132, 12, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 32 },
                    { 133, 13, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 33 },
                    { 134, 14, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 34 },
                    { 135, 15, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 35 },
                    { 136, 16, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 36 },
                    { 137, 17, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 37 },
                    { 138, 18, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 38 },
                    { 139, 19, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 39 },
                    { 140, 20, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 40 },
                    { 141, 1, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 41 },
                    { 142, 2, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 42 },
                    { 143, 3, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 43 },
                    { 144, 4, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 44 },
                    { 145, 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 45 },
                    { 146, 6, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 46 },
                    { 147, 7, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 47 },
                    { 148, 8, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 48 },
                    { 149, 9, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 49 },
                    { 150, 10, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 50 },
                    { 151, 11, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 1 },
                    { 152, 12, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 2 },
                    { 153, 13, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 3 },
                    { 154, 14, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 4 },
                    { 155, 15, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 5 },
                    { 156, 16, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 6 },
                    { 157, 17, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 7 },
                    { 158, 18, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 8 },
                    { 159, 19, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 9 },
                    { 160, 20, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 10 },
                    { 161, 1, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 11 },
                    { 162, 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 12 },
                    { 163, 3, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 13 },
                    { 164, 4, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 14 },
                    { 165, 5, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 15 },
                    { 166, 6, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 16 },
                    { 167, 7, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 17 },
                    { 168, 8, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 18 },
                    { 169, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 19 },
                    { 170, 10, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 20 },
                    { 171, 11, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 21 },
                    { 172, 12, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 22 },
                    { 173, 13, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 23 },
                    { 174, 14, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 24 },
                    { 175, 15, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 25 },
                    { 176, 16, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 26 },
                    { 177, 17, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 27 },
                    { 178, 18, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 28 },
                    { 179, 19, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 29 },
                    { 180, 20, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 30 },
                    { 181, 1, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 31 },
                    { 182, 2, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 32 },
                    { 183, 3, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 33 },
                    { 184, 4, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 34 },
                    { 185, 5, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 35 },
                    { 186, 6, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 36 },
                    { 187, 7, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 37 },
                    { 188, 8, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 38 },
                    { 189, 9, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 39 },
                    { 190, 10, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 40 },
                    { 191, 11, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 41 },
                    { 192, 12, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 42 },
                    { 193, 13, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 43 },
                    { 194, 14, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 44 },
                    { 195, 15, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 45 },
                    { 196, 16, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 46 },
                    { 197, 17, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 47 },
                    { 198, 18, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 48 },
                    { 199, 19, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 49 },
                    { 200, 20, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 50 },
                    { 201, 1, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 1 },
                    { 202, 2, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 2 },
                    { 203, 3, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 3 },
                    { 204, 4, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 4 },
                    { 205, 5, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 5 },
                    { 206, 6, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 6 },
                    { 207, 7, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 7 },
                    { 208, 8, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 8 },
                    { 209, 9, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 9 },
                    { 210, 10, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 10 },
                    { 211, 11, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 11 },
                    { 212, 12, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 12 },
                    { 213, 13, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 13 },
                    { 214, 14, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 14 },
                    { 215, 15, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 15 },
                    { 216, 16, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 16 },
                    { 217, 17, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 17 },
                    { 218, 18, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 18 },
                    { 219, 19, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 19 },
                    { 220, 20, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 20 },
                    { 221, 1, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 21 },
                    { 222, 2, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 22 },
                    { 223, 3, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 23 },
                    { 224, 4, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 24 },
                    { 225, 5, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 25 },
                    { 226, 6, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 26 },
                    { 227, 7, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 27 },
                    { 228, 8, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 28 },
                    { 229, 9, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 29 },
                    { 230, 10, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 30 },
                    { 231, 11, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 31 },
                    { 232, 12, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 32 },
                    { 233, 13, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 33 },
                    { 234, 14, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 34 },
                    { 235, 15, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 35 },
                    { 236, 16, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 36 },
                    { 237, 17, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 37 },
                    { 238, 18, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 38 },
                    { 239, 19, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 39 },
                    { 240, 20, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 40 },
                    { 241, 1, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 41 },
                    { 242, 2, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 42 },
                    { 243, 3, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 43 },
                    { 244, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 44 },
                    { 245, 5, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 45 },
                    { 246, 6, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 46 },
                    { 247, 7, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 47 },
                    { 248, 8, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 48 },
                    { 249, 9, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 49 },
                    { 250, 10, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 50 },
                    { 251, 11, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 1 },
                    { 252, 12, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 2 },
                    { 253, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 3 },
                    { 254, 14, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 4 },
                    { 255, 15, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 5 },
                    { 256, 16, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 6 },
                    { 257, 17, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 7 },
                    { 258, 18, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 8 },
                    { 259, 19, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 9 },
                    { 260, 20, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 10 },
                    { 261, 1, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 11 },
                    { 262, 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 12 },
                    { 263, 3, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 13 },
                    { 264, 4, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 14 },
                    { 265, 5, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 15 },
                    { 266, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 16 },
                    { 267, 7, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 17 },
                    { 268, 8, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 18 },
                    { 269, 9, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 19 },
                    { 270, 10, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 20 },
                    { 271, 11, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 21 },
                    { 272, 12, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 22 },
                    { 273, 13, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 23 },
                    { 274, 14, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 24 },
                    { 275, 15, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 25 },
                    { 276, 16, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 26 },
                    { 277, 17, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 27 },
                    { 278, 18, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 28 },
                    { 279, 19, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 29 },
                    { 280, 20, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 30 },
                    { 281, 1, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 31 },
                    { 282, 2, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 32 },
                    { 283, 3, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 33 },
                    { 284, 4, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 34 },
                    { 285, 5, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 35 },
                    { 286, 6, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 36 },
                    { 287, 7, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 37 },
                    { 288, 8, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 38 },
                    { 289, 9, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 39 },
                    { 290, 10, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 40 },
                    { 291, 11, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 41 },
                    { 292, 12, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 42 },
                    { 293, 13, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 43 },
                    { 294, 14, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 44 },
                    { 295, 15, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 45 },
                    { 296, 16, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 46 },
                    { 297, 17, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 47 },
                    { 298, 18, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 48 },
                    { 299, 19, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 49 },
                    { 300, 20, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 50 },
                    { 301, 1, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 1 },
                    { 302, 2, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 2 },
                    { 303, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 3 },
                    { 304, 4, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 4 },
                    { 305, 5, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 5 },
                    { 306, 6, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 6 },
                    { 307, 7, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 7 },
                    { 308, 8, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 8 },
                    { 309, 9, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 9 },
                    { 310, 10, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 10 },
                    { 311, 11, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 11 },
                    { 312, 12, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 12 },
                    { 313, 13, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 13 },
                    { 314, 14, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 14 },
                    { 315, 15, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 15 },
                    { 316, 16, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 16 },
                    { 317, 17, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 17 },
                    { 318, 18, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 18 },
                    { 319, 19, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 19 },
                    { 320, 20, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 20 },
                    { 321, 1, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 21 },
                    { 322, 2, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 22 },
                    { 323, 3, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 23 },
                    { 324, 4, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 24 },
                    { 325, 5, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 25 },
                    { 326, 6, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 26 },
                    { 327, 7, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 27 },
                    { 328, 8, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 28 },
                    { 329, 9, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 29 },
                    { 330, 10, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 30 },
                    { 331, 11, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 31 },
                    { 332, 12, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 32 },
                    { 333, 13, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 33 },
                    { 334, 14, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 34 },
                    { 335, 15, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 35 },
                    { 336, 16, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 36 },
                    { 337, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 37 },
                    { 338, 18, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 38 },
                    { 339, 19, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 39 },
                    { 340, 20, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 40 },
                    { 341, 1, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 41 },
                    { 342, 2, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 42 },
                    { 343, 3, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 43 },
                    { 344, 4, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 44 },
                    { 345, 5, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 45 },
                    { 346, 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 46 },
                    { 347, 7, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 47 },
                    { 348, 8, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 48 },
                    { 349, 9, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 49 },
                    { 350, 10, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 50 },
                    { 351, 11, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 1 },
                    { 352, 12, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 2 },
                    { 353, 13, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 3 },
                    { 354, 14, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 4 },
                    { 355, 15, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 5 },
                    { 356, 16, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 6 },
                    { 357, 17, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 7 },
                    { 358, 18, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 8 },
                    { 359, 19, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 9 },
                    { 360, 20, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 10 },
                    { 361, 1, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 11 },
                    { 362, 2, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 12 },
                    { 363, 3, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 13 },
                    { 364, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 14 },
                    { 365, 5, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 15 },
                    { 366, 6, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 16 },
                    { 367, 7, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 17 },
                    { 368, 8, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 18 },
                    { 369, 9, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 19 },
                    { 370, 10, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 20 },
                    { 371, 11, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 21 },
                    { 372, 12, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 22 },
                    { 373, 13, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 23 },
                    { 374, 14, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 24 },
                    { 375, 15, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 25 },
                    { 376, 16, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 26 },
                    { 377, 17, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 27 },
                    { 378, 18, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 28 },
                    { 379, 19, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 29 },
                    { 380, 20, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 30 },
                    { 381, 1, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 31 },
                    { 382, 2, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 32 },
                    { 383, 3, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 33 },
                    { 384, 4, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 34 },
                    { 385, 5, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 35 },
                    { 386, 6, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 36 },
                    { 387, 7, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 37 },
                    { 388, 8, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 38 },
                    { 389, 9, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 39 },
                    { 390, 10, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 40 },
                    { 391, 11, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 41 },
                    { 392, 12, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 42 },
                    { 393, 13, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 43 },
                    { 394, 14, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 44 },
                    { 395, 15, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 45 },
                    { 396, 16, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 46 },
                    { 397, 17, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 47 },
                    { 398, 18, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 48 },
                    { 399, 19, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 49 },
                    { 400, 20, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 50 },
                    { 401, 1, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 1 },
                    { 402, 2, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 2 },
                    { 403, 3, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 3 },
                    { 404, 4, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 4 },
                    { 405, 5, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 5 },
                    { 406, 6, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 6 },
                    { 407, 7, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 7 },
                    { 408, 8, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 8 },
                    { 409, 9, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 9 },
                    { 410, 10, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 10 },
                    { 411, 11, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 11 },
                    { 412, 12, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 12 },
                    { 413, 13, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 13 },
                    { 414, 14, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 14 },
                    { 415, 15, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 15 },
                    { 416, 16, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 16 },
                    { 417, 17, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 17 },
                    { 418, 18, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 18 },
                    { 419, 19, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 19 },
                    { 420, 20, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 20 },
                    { 421, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 21 },
                    { 422, 2, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 22 },
                    { 423, 3, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 23 },
                    { 424, 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 24 },
                    { 425, 5, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 25 },
                    { 426, 6, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 26 },
                    { 427, 7, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 27 },
                    { 428, 8, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 28 },
                    { 429, 9, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 29 },
                    { 430, 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 30 },
                    { 431, 11, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 31 },
                    { 432, 12, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 32 },
                    { 433, 13, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 33 },
                    { 434, 14, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 34 },
                    { 435, 15, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 35 },
                    { 436, 16, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 36 },
                    { 437, 17, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 37 },
                    { 438, 18, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 38 },
                    { 439, 19, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 39 },
                    { 440, 20, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 40 },
                    { 441, 1, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 41 },
                    { 442, 2, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 42 },
                    { 443, 3, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 43 },
                    { 444, 4, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 44 },
                    { 445, 5, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 45 },
                    { 446, 6, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 46 },
                    { 447, 7, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 47 },
                    { 448, 8, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 48 },
                    { 449, 9, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 49 },
                    { 450, 10, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 50 },
                    { 451, 11, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 1 },
                    { 452, 12, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 2 },
                    { 453, 13, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 3 },
                    { 454, 14, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 4 },
                    { 455, 15, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 5 },
                    { 456, 16, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 6 },
                    { 457, 17, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 7 },
                    { 458, 18, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 8 },
                    { 459, 19, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 9 },
                    { 460, 20, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 10 },
                    { 461, 1, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 11 },
                    { 462, 2, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 12 },
                    { 463, 3, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 13 },
                    { 464, 4, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 14 },
                    { 465, 5, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 15 },
                    { 466, 6, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 16 },
                    { 467, 7, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 17 },
                    { 468, 8, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 18 },
                    { 469, 9, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 19 },
                    { 470, 10, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 20 },
                    { 471, 11, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 21 },
                    { 472, 12, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 22 },
                    { 473, 13, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 23 },
                    { 474, 14, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 24 },
                    { 475, 15, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 25 },
                    { 476, 16, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 26 },
                    { 477, 17, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 27 },
                    { 478, 18, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 28 },
                    { 479, 19, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 29 },
                    { 480, 20, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 30 },
                    { 481, 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 31 },
                    { 482, 2, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 32 },
                    { 483, 3, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 33 },
                    { 484, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 34 },
                    { 485, 5, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 35 },
                    { 486, 6, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 36 },
                    { 487, 7, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 37 },
                    { 488, 8, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 38 },
                    { 489, 9, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 39 },
                    { 490, 10, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 40 },
                    { 491, 11, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 41 },
                    { 492, 12, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 42 },
                    { 493, 13, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 43 },
                    { 494, 14, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 44 },
                    { 495, 15, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 45 },
                    { 496, 16, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 46 },
                    { 497, 17, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 47 },
                    { 498, 18, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive", 48 },
                    { 499, 19, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 49 },
                    { 500, 20, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "SemesterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "SemesterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "SemesterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "SemesterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "SemesterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 10);
        }
    }
}
