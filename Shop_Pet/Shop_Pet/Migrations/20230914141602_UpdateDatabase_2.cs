using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_Pet.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { "1", "admin@gmail.com", "admin", "123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
