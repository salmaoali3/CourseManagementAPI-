using System.ComponentModel.DataAnnotations;

namespace CourseManagementAPI.Models; // Updated to match your project name

public class Students
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    // --- The Link (Objective 17: Foreign Key) ---
    // This connects the Student to a specific Course
    public int CourseId { get; set; } 
    
    // Navigation Property: Allows the API to "include" Course details when fetching a Student
    public Course? Course { get; set; } 
}