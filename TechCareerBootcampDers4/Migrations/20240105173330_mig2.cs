using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerBootcampDers4.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_webUsers_webUserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_webUsers",
                table: "webUsers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_webUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "webUserId",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "webUsers",
                newName: "WebUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebUsers",
                table: "WebUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrderWebUser",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    WebUsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderWebUser", x => new { x.OrdersId, x.WebUsersId });
                    table.ForeignKey(
                        name: "FK_OrderWebUser_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderWebUser_WebUsers_WebUsersId",
                        column: x => x.WebUsersId,
                        principalTable: "WebUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderWebUser_WebUsersId",
                table: "OrderWebUser",
                column: "WebUsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderWebUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebUsers",
                table: "WebUsers");

            migrationBuilder.RenameTable(
                name: "WebUsers",
                newName: "webUsers");

            migrationBuilder.AddColumn<int>(
                name: "webUserId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_webUsers",
                table: "webUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_webUserId",
                table: "Orders",
                column: "webUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_webUsers_webUserId",
                table: "Orders",
                column: "webUserId",
                principalTable: "webUsers",
                principalColumn: "Id");
        }
    }
}
