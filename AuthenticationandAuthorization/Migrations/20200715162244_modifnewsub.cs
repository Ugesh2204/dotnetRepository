using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationandAuthorization.Migrations
{
    public partial class modifnewsub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.AddColumn<double>(
                name: "AmountToBePaid",
                table: "Subcriptions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Subcriptions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MorePaymentRequired",
                table: "Subcriptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PaymentDate",
                table: "Subcriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Subcriptions",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RemainingAmount",
                table: "Subcriptions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Subcriptions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountToBePaid",
                table: "Subcriptions");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Subcriptions");

            migrationBuilder.DropColumn(
                name: "MorePaymentRequired",
                table: "Subcriptions");

            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "Subcriptions");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Subcriptions");

            migrationBuilder.DropColumn(
                name: "RemainingAmount",
                table: "Subcriptions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Subcriptions");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmountToBePaid = table.Column<double>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    MorePaymentRequired = table.Column<bool>(nullable: false),
                    PaymentDate = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<string>(nullable: true),
                    PaymentReceived = table.Column<bool>(nullable: false),
                    RemainingAmount = table.Column<double>(nullable: false),
                    SubId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Subcriptions_SubId",
                        column: x => x.SubId,
                        principalTable: "Subcriptions",
                        principalColumn: "SubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubId",
                table: "Payments",
                column: "SubId");
        }
    }
}
