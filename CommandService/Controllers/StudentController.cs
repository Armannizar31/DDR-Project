using CommandService.Commands.Interfaces;
using CommandService.Models;
using CommonData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentCommand _studentCommand;
        public StudentController(IStudentCommand studentCommand)
        {
            _studentCommand = studentCommand;
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentCommandModel model)
        {
            try
            {
                var student = await _studentCommand.AddStudentAsync(model);
                return StatusCode(StatusCodes.Status201Created, student);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
