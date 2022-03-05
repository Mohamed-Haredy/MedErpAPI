using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedErp.Infrastructure.Migrations
{
    public partial class appointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<long>(type: "bigint", nullable: true),
                    doctorid = table.Column<long>(type: "bigint", nullable: true),
                    appointmentdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    appointmenttype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_appointments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentTypes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typename = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_appointmenttypes", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "AppointmentTypes",
                columns: new[] { "id", "clientid", "createby", "createdate", "isremoved", "note", "typename", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 1L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Admission", null, null },
                    { 2L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Consultation", null, null },
                    { 3L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Consultation Gynéco", null, null },
                    { 4L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Consultation MG", null, null },
                    { 5L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Consultation Rhumato", null, null },
                    { 6L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Imaging", null, null },
                    { 7L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Lab", null, null },
                    { 8L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Pharmacy", null, null },
                    { 9L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Testing", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentTypes");
        }
    }
}
