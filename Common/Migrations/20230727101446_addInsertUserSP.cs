using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Common.Migrations
{
    public partial class addInsertUserSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string query = "CREATE OR ALTER PROCEDURE AddUserSP\r\n    @FirstName nvarchar(50),   \r\n\t@LastName nvarchar(50),\r\n\t@Email nvarchar(50),\r\n\t@DOB date,\r\n\t@Address nvarchar(max)\r\nAS   \r\n   Insert into Users(firstname,lastname,email,dob,address) values(@FirstName,@LastName,@Email,@DOB,@Address) \r\nGO";
            migrationBuilder.Sql(query);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop proc AddUserSP");
        }
    }
}
