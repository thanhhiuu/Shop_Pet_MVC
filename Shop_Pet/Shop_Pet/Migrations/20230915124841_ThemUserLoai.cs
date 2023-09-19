using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_Pet.Migrations
{
    /// <inheritdoc />
    public partial class ThemUserLoai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoaiUser",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: "1",
                column: "LoaiUser",
                value: 1);

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Email", "LoaiUser", "Name", "Password" },
                values: new object[] { "2", "hieu@gmail.com", 0, "hieu", "123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "LoaiUser",
                table: "Account");
        }
    }
}
