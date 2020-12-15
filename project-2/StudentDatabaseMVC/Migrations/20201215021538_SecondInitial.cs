using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDatabaseMVC.Migrations
{
    public partial class SecondInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber", "Program" },
                values: new object[] { 3494L, new DateTime(1997, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "thomj@gmatc.matc.edu", "Jack", "Thompson", "262-422-2020", "Electrical Engineering" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber", "Program" },
                values: new object[] { 39931L, new DateTime(1999, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "turnerr@gmatc.matc.edu", "Robin", "Turner", "414-555-8888", "Undecided" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber", "Program" },
                values: new object[] { 2748L, new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "barnesa@gmatc.matc.edu", "Alison", "Barnes", "262-202-3320", "Education" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2748L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3494L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39931L);
        }
    }
}
