using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // private  DataContext _context = new DataContext();

        // public StudentController(DataContext studentService)
        // {
        //     _context = studentService;
        // }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudent()
        {
           DataContext _context = new DataContext();
            return _context.Student;
        }
    }
}