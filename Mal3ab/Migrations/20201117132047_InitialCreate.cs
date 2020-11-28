using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mal3ab.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    price_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price_hour = table.Column<decimal>(type: "decimal(5,1)", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.price_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_iduser_id = table.Column<int>(type: "int", nullable: true),
                    creator_iduser_id = table.Column<int>(type: "int", nullable: true),
                    approver_iduser_id = table.Column<int>(type: "int", nullable: true),
                    price_hour = table.Column<decimal>(type: "decimal(5,1)", nullable: false),
                    from = table.Column<DateTime>(type: "datetime2", nullable: false),
                    to = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reservation_type = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.reservation_id);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_approver_iduser_id",
                        column: x => x.approver_iduser_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_client_iduser_id",
                        column: x => x.client_iduser_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_creator_iduser_id",
                        column: x => x.creator_iduser_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weekly_reservations",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_iduser_id = table.Column<int>(type: "int", nullable: true),
                    creator_iduser_id = table.Column<int>(type: "int", nullable: true),
                    from = table.Column<DateTime>(type: "datetime2", nullable: false),
                    to = table.Column<DateTime>(type: "datetime2", nullable: false),
                    day = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weekly_reservations", x => x.reservation_id);
                    table.ForeignKey(
                        name: "FK_Weekly_reservations_Users_client_iduser_id",
                        column: x => x.client_iduser_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weekly_reservations_Users_creator_iduser_id",
                        column: x => x.creator_iduser_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_approver_iduser_id",
                table: "Reservations",
                column: "approver_iduser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_client_iduser_id",
                table: "Reservations",
                column: "client_iduser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_creator_iduser_id",
                table: "Reservations",
                column: "creator_iduser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Weekly_reservations_client_iduser_id",
                table: "Weekly_reservations",
                column: "client_iduser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Weekly_reservations_creator_iduser_id",
                table: "Weekly_reservations",
                column: "creator_iduser_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Weekly_reservations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
