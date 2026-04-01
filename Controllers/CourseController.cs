using Microsoft.AspNetCore.Mvc;
using CourseManagementAPI.Data;   // Changed from WebApplication1
using CourseManagementAPI.Models; // Changed from WebApplication1

namespace CourseManagementAPI.Controllers; // Changed from WebApplication1

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    private readonly AppDbContext _context;

    public CoursesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetCourses()
    {
        var courses = _context.Courses.ToList();
        return Ok(courses);
    }

    [HttpPost]
    public IActionResult CreateCourse([FromBody] Course course)
    {
        if (course == null) 
        {
            return BadRequest("Course data is null");
        }

        _context.Courses.Add(course);
        _context.SaveChanges();

        // This returns the 201 Created status code required by your professor
        return CreatedAtAction(nameof(GetCourses), new { id = course.Id }, course);
    }
}