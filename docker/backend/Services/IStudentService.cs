using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Services
{
    public interface IStudentService 
    {
        IEnumerable<Student> GetStudentList();
    }
}