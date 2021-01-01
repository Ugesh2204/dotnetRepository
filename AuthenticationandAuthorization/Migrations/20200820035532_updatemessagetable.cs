using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationandAuthorization.Migrations
{
    public partial class updatemessagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Comment_status",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FromUserName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MessageHeader",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToUserId",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ToUserName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Messages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment_status",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "FromUserName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageHeader",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ToUserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ToUserName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Messages");
        }
    }
}
