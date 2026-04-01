using System.ComponentModel.DataAnnotations;

namespace CourseManagementAPI.Models; // Updated to match your project name

public class Courses
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public int InstructorId { get; set; } // Foreign Key

    // Navigation property
    public Instructor? Instructor { get; set; }
    
    // Relationship to Students
    public List<Student> Students { get; set; } = new List<Student>();
}