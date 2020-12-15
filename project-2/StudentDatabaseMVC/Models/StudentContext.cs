using Microsoft.EntityFrameworkCore;
using System;

namespace StudentDatabaseMVC.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 1232,
                FirstName = "Sally",
                LastName = "Goodman",
                Program = "Business Administration",
                DateOfBirth = new DateTime(2000, 09, 13),
                PhoneNumber = "414-555-9102",
                Email = "goodsally@gmail.com"

            }, new Student
            {
                StudentId = 4828,
                FirstName = "Marsha",
                LastName = "Bronson",
                Program = "Architecture",
                DateOfBirth = new DateTime(1998, 10, 13),
                PhoneNumber = "262-555-0929",
                Email = "bmarsha@gmatc.matc.edu"
            }, new Student
            {
                StudentId = 3494,
                FirstName = "Jack",
                LastName = "Thompson",
                Program = "Electrical Engineering",
                DateOfBirth = new DateTime(1997, 01, 15),
                PhoneNumber = "262-422-2020",
                Email = "thomj@gmatc.matc.edu"
            }, new Student
            {
                StudentId = 39931,
                FirstName = "Robin",
                LastName = "Turner",
                Program = "Undecided",
                DateOfBirth = new DateTime(1999, 03, 17),
                PhoneNumber = "414-555-8888",
                Email = "turnerr@gmatc.matc.edu"
            }, new Student
            {
                StudentId = 2748,
                FirstName = "Alison",
                LastName = "Barnes",
                Program = "Education",
                DateOfBirth = new DateTime(1998, 05, 19),
                PhoneNumber = "262-202-3320",
                Email = "barnesa@gmatc.matc.edu"
            }
            
            );
            
        }
}
}
