using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization; 
using CourseManagementAPI.Data;   // Updated from WebApplication1
using CourseManagementAPI.Models; // Updated from WebApplication1

namespace CourseManagementAPI.Controllers; // Updated from WebApplication1

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public StudentsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Students
    [HttpGet]
    public IActionResult GetStudents()
    {
        var students = _context.Students.ToList();
        return Ok(students);
    }

    // POST: api/Students
    [HttpPost]
    public IActionResult CreateStudent([FromBody] Student student)
    {
        if (student == null)
        {
            return BadRequest("Student data is null");
        }

        _context.Students.Add(student);
        _context.SaveChanges(); 

        // Returns 201 Created status code for your screenshot requirement
        return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
    }
}