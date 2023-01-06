using CommandService.Commands.Interfaces;
using CommandService.Models;
using CommonData;
using System.Net.Http.Headers;

namespace CommandService.Commands.Handlers
{
    public class StudentCommand: IStudentCommand
    {
        AppDbContext _db;
        public StudentCommand(AppDbContext db)
        {
            _db = db;
        }
        public async Task<StudentCommandModel> AddStudentAsync(StudentCommandModel model)
        {
            Student student = new Student
            {
                studentFname = model.studentFname,
                studentLname = model.studentLname,
                studentAge = model.studentAge,
                studentGender = model.studentGender,
                studentClass = model.studentClass
            };
            _db.Students.Add(student);
            await _db.SaveChangesAsync();
            model.studentId = student.studentId;
            return model;
        }
    }
}
