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
            });
        }
}
}
