using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetdocker.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Data>> Get()
        {
            DataContext _context = new DataContext();
            //_context.Data.ToList();
            return _context.Data;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<List<Data>> Get(int id)
        {
            DataContext _context = new DataContext();
            var studentsWithSameName = _context.Data.Where(o => o.Id == id).ToList();
            return studentsWithSameName.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Data data)
        {
            var newData = new Data();
            newData = data;
            DataContext _context = new DataContext();
            _context.Data.Add(newData);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
