using System.Collections.Generic;
using StudentDatabaseMVC.Models;
using StudentDatabaseMVC.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace StudentDatabaseMVC.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IDataRepository<Student> _dataRepository;

        public StudentController(IDataRepository<Student> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Student
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Student> students = _dataRepository.GetAll();
            return Ok(students);
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Student student = _dataRepository.Get(id);

            if (student == null)
            {
                return NotFound("The Student record couldn't be found.");
            }

            return Ok(student);
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student Not Found");
            }

            _dataRepository.Add(student);
            return CreatedAtRoute(
                  "Get",
                  new { Id = student.StudentId },
                  student);
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Value is null.");
            }

            Student studentToUpdate = _dataRepository.Get(id);
            if (studentToUpdate == null)
            {
                return NotFound("Record couldn't be found.");
            }

            _dataRepository.Update(studentToUpdate, student);
            return NoContent();
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Student student = _dataRepository.Get(id);
            if (student == null)
            {
                return NotFound("Record can't be found");
            }

            _dataRepository.Delete(student);
            return NoContent();
        }
    }
}