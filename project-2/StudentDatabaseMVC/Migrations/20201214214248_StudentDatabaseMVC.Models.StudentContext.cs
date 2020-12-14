using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDatabaseMVC.Migrations
{
    public partial class StudentDatabaseMVCModelsStudentContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Program = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber", "Program" },
                values: new object[] { 1232L, new DateTime(2000, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "goodsally@gmail.com", "Sally", "Goodman", "414-555-9102", "Business Administration" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber", "Program" },
                values: new object[] { 4828L, new DateTime(1998, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "bmarsha@gmatc.matc.edu", "Marsha", "Bronson", "262-555-0929", "Architecture" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
