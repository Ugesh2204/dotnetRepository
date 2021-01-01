using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationandAuthorization.Migrations
{
    public partial class subnpaymentmodify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Subcriptions");

            migrationBuilder.RenameColumn(
                name: "SubName",
                table: "Subcriptions",
                newName: "MembershipName");

            migrationBuilder.RenameColumn(
                name: "Mprice",
                table: "Subcriptions",
                newName: "Amount");

            migrationBuilder.AddColumn<bool>(
                name: "MorePaymentRequired",
                table: "Payments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PaymentReceived",
                table: "Payments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MorePaymentRequired",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentReceived",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "MembershipName",
                table: "Subcriptions",
                newName: "SubName");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Subcriptions",
                newName: "Mprice");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Subcriptions",
                nullable: false,
                defaultValue: false);
        }
    }
}
