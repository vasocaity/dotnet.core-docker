using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _datacontext;

        public StudentService(DataContext dataContext)
        {
            _datacontext = dataContext;
        }

        public IEnumerable<Student> GetStudentList()
        {
            return  _datacontext.Student;
        }
    }
}