using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerShopBlazor.Migrations
{
    public partial class SneakerShopDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Useraname",
                table: "AccountUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountUsers_Useraname",
                table: "AccountUsers",
                column: "Useraname",
                unique: true,
                filter: "[Useraname] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AccountUsers_Useraname",
                table: "AccountUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Useraname",
                table: "AccountUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
