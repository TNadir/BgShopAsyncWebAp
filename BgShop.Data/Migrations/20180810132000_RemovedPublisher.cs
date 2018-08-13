using Microsoft.EntityFrameworkCore.Migrations;

namespace BgShop.Data.Migrations
{
    public partial class RemovedPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "publisher",
                table: "Games");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "publisher",
                table: "Games",
                nullable: false,
                defaultValue: 0);
        }
    }
}
