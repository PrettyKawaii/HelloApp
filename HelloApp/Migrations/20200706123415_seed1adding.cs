using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloApp.Migrations
{
    public partial class seed1adding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Users",
               columns: new[] {"Id", "Name", "Age" },
               values: new object[,]
               {
                     {1, "Sanya", 13},
                     {2, "Petrasyan", 25}
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
