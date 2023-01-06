using CommandService.Models;

namespace CommandService.Commands.Interfaces
{
    public interface IStudentCommand
    {
        Task<StudentCommandModel> AddStudentAsync(StudentCommandModel model);
        Task<bool> UpdateStudentAsync(StudentCommandModel model);
        Task<bool> DeleteStudentAsync(int id);
    }
}
