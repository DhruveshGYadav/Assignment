using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Common.Migrations
{
    public partial class addInsertUserExperienceSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string query = "CREATE OR ALTER PROCEDURE AddUserExperiencesSP\r\n    @FromDate date,   \r\n\t@ToDate date,\r\n\t@Position nvarchar(50),\r\n\t@CompanyName nvarchar(100),\r\n\t@UserId int\r\nAS   \r\n   Insert into UserExperiences(FromDate,ToDate,Position,CompanyName,UserId) values(@FromDate,@ToDate,@Position,@CompanyName,@UserId) \r\nGO";
            migrationBuilder.Sql(query);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop proc AddUserExperiencesSP");
        }
    }
}
