using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagementSystem.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true),
                    CityOfResidence = table.Column<string>(nullable: true),
                    Department = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "CityOfResidence", "Department", "FirstName", "LastName", "StudentId" },
                values: new object[] { 1, "Dhaka", 0, "Hossain", "Tanvir", "123451" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "CityOfResidence", "Department", "FirstName", "LastName", "StudentId" },
                values: new object[] { 2, "Dhaka", 1, "Ali", "Mohammad", "123452" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "CityOfResidence", "Department", "FirstName", "LastName", "StudentId" },
                values: new object[] { 3, "Dhaka", 3, "Ahamed", "Foysal", "123453" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "CityOfResidence", "Department", "FirstName", "LastName", "StudentId" },
                values: new object[] { 4, "Dhaka", 2, "Miah", "Tuhin", "123454" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
