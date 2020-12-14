﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentDatabaseMVC.Models;

namespace StudentDatabaseMVC.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentDatabaseMVC.Models.Student", b =>
                {
                    b.Property<long>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = 1232L,
                            DateOfBirth = new DateTime(2000, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "goodsally@gmail.com",
                            FirstName = "Sally",
                            LastName = "Goodman",
                            PhoneNumber = "414-555-9102",
                            Program = "Business Administration"
                        },
                        new
                        {
                            StudentId = 4828L,
                            DateOfBirth = new DateTime(1998, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bmarsha@gmatc.matc.edu",
                            FirstName = "Marsha",
                            LastName = "Bronson",
                            PhoneNumber = "262-555-0929",
                            Program = "Architecture"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
