using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedErp.Infrastructure.Migrations
{
    public partial class IntialStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    requestdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    requestby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fulfill = table.Column<bool>(type: "bit", nullable: true),
                    aisleid = table.Column<long>(type: "bigint", nullable: true),
                    supplyerid = table.Column<long>(type: "bigint", nullable: true),
                    clientid = table.Column<long>(type: "bigint", nullable: false),
                    isremoved = table.Column<bool>(type: "bit", nullable: false),
                    createby = table.Column<long>(type: "bigint", nullable: false),
                    updatedby = table.Column<long>(type: "bigint", nullable: true),
                    createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_inventories", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
