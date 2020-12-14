using System.Collections.Generic;
using System.Linq;
using StudentDatabaseMVC.Models.Repository;

namespace StudentDatabaseMVC.Models.DataManager
{
    public class StudentManager : IDataRepository<Student>
    {
        readonly StudentContext _studentContext;

        public StudentManager(StudentContext context)
        {
            _studentContext = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentContext.Students.ToList();
        }

        public Student Get(long id)
        {
            return _studentContext.Students.FirstOrDefault(e => e.StudentId == id);
        }

        public void Add(Student entity)
        {
            _studentContext.Students.Add(entity);
            _studentContext.SaveChanges();
        }

        public void Update(Student student, Student entity)
        {
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.Email = entity.Email;
            student.DateOfBirth = entity.DateOfBirth;
            student.PhoneNumber = entity.PhoneNumber;

            _studentContext.SaveChanges();
        }

        public void Delete(Student student)
        {
            _studentContext.Students.Remove(student);
            _studentContext.SaveChanges();
        }

        IEnumerable<Student> IDataRepository<Student>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}