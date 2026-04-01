using System.Collections.Generic;

namespace CourseManagementAPI.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // One-to-One
        public InstructorProfile? Profile { get; set; }
        // One-to-Many
        public List<Course> Courses { get; set; } = new();
    }

    public class InstructorProfile
    {
        public int Id { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int InstructorId { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int InstructorId { get; set; }
        // Many-to-Many
        public List<Student> Students { get; set; } = new();
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Course> Courses { get; set; } = new();
    }
}