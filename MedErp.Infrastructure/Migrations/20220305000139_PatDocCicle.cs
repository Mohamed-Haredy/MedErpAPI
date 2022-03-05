using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedErp.Infrastructure.Migrations
{
    public partial class PatDocCicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmittedPatients",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<long>(type: "bigint", nullable: true),
                    doctorid = table.Column<long>(type: "bigint", nullable: true),
                    checkin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_admittedpatients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Aisles",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aislelocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_aisles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryname = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("pk_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    middlename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinicsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    specializationtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_doctors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IBloodTypes",
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
                    table.PrimaryKey("pk_ibloodtypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeid = table.Column<long>(type: "bigint", nullable: true),
                    crossreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reorderpoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salepriceperunit = table.Column<float>(type: "real", nullable: true),
                    distributionunit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datereceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invoicenumber = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    unit = table.Column<int>(type: "int", nullable: true),
                    purchasecost = table.Column<float>(type: "real", nullable: true),
                    serialnumber = table.Column<int>(type: "int", nullable: true),
                    expirationdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    vendorid = table.Column<long>(type: "bigint", nullable: true),
                    aisleid = table.Column<long>(type: "bigint", nullable: true),
                    giftinkind = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("pk_items", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
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
                    table.PrimaryKey("pk_itemtypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OutPatients",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    admittedid = table.Column<long>(type: "bigint", nullable: true),
                    checkout = table.Column<DateTime>(type: "datetime2", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_outpatients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    middlename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    placeofbirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patienttype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patientstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinicsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guardian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_patients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    religionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_religions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addresslocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vendoritemnumber = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("pk_vendors", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "clientid", "countryname", "createby", "createdate", "isremoved", "note", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 1L, 0L, "Afghanistan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 2L, 0L, "Albania", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 3L, 0L, "Algeria", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 4L, 0L, "American Samoa", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 5L, 0L, "Andorra", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 6L, 0L, "Angola", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 7L, 0L, "Anguilla", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 8L, 0L, "Antarctica", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 9L, 0L, "Antigua and Barbuda", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 10L, 0L, "Argentina", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 11L, 0L, "Armenia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 12L, 0L, "Aruba", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 13L, 0L, "Australia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 14L, 0L, "Austria", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 15L, 0L, "Azerbaijan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 16L, 0L, "Bahamas", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 17L, 0L, "Bahrain", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 18L, 0L, "Bangladesh", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 19L, 0L, "Barbados", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 20L, 0L, "Belarus", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 21L, 0L, "Belgium", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 22L, 0L, "Belize", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 23L, 0L, "Benin", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 24L, 0L, "Bermuda", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 25L, 0L, "Bhutan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 26L, 0L, "Bolivia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 27L, 0L, "Bosnia and Herzegovina", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 28L, 0L, "Botswana", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 29L, 0L, "Bouvet Island", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 30L, 0L, "Brazil", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 31L, 0L, "British Indian Ocean Territories", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 32L, 0L, "Brunei Darussalam", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 33L, 0L, "Bulgaria", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 34L, 0L, "Burkina Faso", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 35L, 0L, "Burundi", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 36L, 0L, "Cambodia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 37L, 0L, "Cameroon", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 38L, 0L, "Canada", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 39L, 0L, "Cape Verde", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 40L, 0L, "Cayman Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 41L, 0L, "Central African Republic", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 42L, 0L, "Chad", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "clientid", "countryname", "createby", "createdate", "isremoved", "note", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 43L, 0L, "Chile", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 44L, 0L, "China", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 45L, 0L, "Christmas Island", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 46L, 0L, "Cocos Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 47L, 0L, "Columbia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 48L, 0L, "Comoros", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 49L, 0L, "Congo", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 50L, 0L, "Cook Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 51L, 0L, "Costa Rica", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 52L, 0L, "Cote D'ivoire", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 53L, 0L, "Croatia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 54L, 0L, "Cuba", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 55L, 0L, "Cyprus", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 56L, 0L, "Czech Republic", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 57L, 0L, "Djibouti", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 58L, 0L, "Dominica", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 59L, 0L, "Dominican Republic", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 60L, 0L, "East Timor", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 61L, 0L, "Ecuador", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 62L, 0L, "Egypt", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 63L, 0L, "El Salvador", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 64L, 0L, "Equatorial Guinea", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 65L, 0L, "Eritrea", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 66L, 0L, "Estonia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 67L, 0L, "Ethiopia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 68L, 0L, "Falkland Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 69L, 0L, "Faroe Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 70L, 0L, "Fiji", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 71L, 0L, "Finland", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 72L, 0L, "France", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 73L, 0L, "France, Metropolitan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 74L, 0L, "French Guiana", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 75L, 0L, "French Polynesia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 76L, 0L, "French Southern Territories", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 77L, 0L, "FYROM", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 78L, 0L, "Gabon", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 79L, 0L, "Gambia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 80L, 0L, "Georgia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 81L, 0L, "Germany", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 82L, 0L, "Ghana", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 83L, 0L, "Gibraltar", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 84L, 0L, "Greece", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "clientid", "countryname", "createby", "createdate", "isremoved", "note", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 85L, 0L, "Greenland", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 86L, 0L, "Grenada", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 87L, 0L, "Guadeloupe", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 88L, 0L, "Guam", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 89L, 0L, "Guatemala", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 90L, 0L, "Guinea", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 91L, 0L, "Guinea-Bissau", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 92L, 0L, "Guyana", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 93L, 0L, "Haiti", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 94L, 0L, "Heard Island And Mcdonald Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 95L, 0L, "Honduras", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 96L, 0L, "Hong Kong", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 97L, 0L, "Hungary", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 98L, 0L, "Iceland", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 99L, 0L, "India", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 100L, 0L, "Indonesia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 101L, 0L, "Iran", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 102L, 0L, "Iraq", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 103L, 0L, "Ireland", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 105L, 0L, "Italy", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 106L, 0L, "Jamaica", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 107L, 0L, "Japan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 108L, 0L, "Jordan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 109L, 0L, "Kazakhstan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 110L, 0L, "Kenya", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 111L, 0L, "Kiribati", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 112L, 0L, "Korea, Democratic Peoples Republic of", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 113L, 0L, "Korea, Republic of", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 114L, 0L, "Kuwait", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 115L, 0L, "Kyrgyzstan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 116L, 0L, "Lao Peoples Democratic Republic", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 117L, 0L, "Latvia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 118L, 0L, "Lebanon", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 119L, 0L, "Lesotho", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 120L, 0L, "Liberia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 121L, 0L, "Libyan Arab Jamahiriya", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 122L, 0L, "Liechtenstein", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 123L, 0L, "Lithuania", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 124L, 0L, "Luxembourg", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 125L, 0L, "Macau", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 126L, 0L, "Madagascar", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 127L, 0L, "Malawi", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "clientid", "countryname", "createby", "createdate", "isremoved", "note", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 128L, 0L, "Malaysia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 129L, 0L, "Maldives", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 130L, 0L, "Mali", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 131L, 0L, "Malta", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 132L, 0L, "Marshall Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 133L, 0L, "Martinique", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 134L, 0L, "Mauritania", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 135L, 0L, "Mauritius", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 136L, 0L, "Mayotte", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 137L, 0L, "Mexico", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 138L, 0L, "Micronesia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 139L, 0L, "Moldova", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 140L, 0L, "Mongolia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 141L, 0L, "Montserrat", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 142L, 0L, "Morocco", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 143L, 0L, "Monaco", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 144L, 0L, "Myanmar", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 145L, 0L, "Mozambique", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 146L, 0L, "Namibia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 147L, 0L, "Nauru", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 148L, 0L, "Nepal", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 149L, 0L, "Netherlands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 150L, 0L, "Netherlands Antilles", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 151L, 0L, "New Caledonia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 152L, 0L, "New Zealand", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 153L, 0L, "Nicaragua", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 154L, 0L, "Niger", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 155L, 0L, "Nigeria", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 156L, 0L, "Niue", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 157L, 0L, "Norfolk Island", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 158L, 0L, "Northern Mariana Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 159L, 0L, "Norway", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 160L, 0L, "Oman", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 161L, 0L, "Pakistan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 162L, 0L, "palestine", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 163L, 0L, "Palau", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 164L, 0L, "Panama", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 165L, 0L, "Papua New Guinea", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 166L, 0L, "Paraguay", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 167L, 0L, "Peru", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 168L, 0L, "Philippines", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 169L, 0L, "Pitcairn", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "clientid", "countryname", "createby", "createdate", "isremoved", "note", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 170L, 0L, "Poland", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 171L, 0L, "Portugal", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 172L, 0L, "Puerto Rico", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 173L, 0L, "Qatar", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 174L, 0L, "Reunion", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 175L, 0L, "Romania", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 176L, 0L, "Russian Federation", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 177L, 0L, "Rwanda", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 178L, 0L, "Saint Helena", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 179L, 0L, "Saint Kitts and Nevis", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 180L, 0L, "Saint Lucia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 181L, 0L, "Saint Pierre and Miquelon", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 182L, 0L, "Saint Vincent and The Grenadines", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 183L, 0L, "Samoa", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 184L, 0L, "San Marino", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 185L, 0L, "Sao Tome and Principe", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 186L, 0L, "Saudi Arabia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 187L, 0L, "Senegal", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 188L, 0L, "Seychelles", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 189L, 0L, "Sierra Leone", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 190L, 0L, "Singapore", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 191L, 0L, "Slovakia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 192L, 0L, "Slovenia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 193L, 0L, "Solomon Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 194L, 0L, "Somalia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 195L, 0L, "South Africa", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 196L, 0L, "South Georgia and Sandwich Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 197L, 0L, "Spain", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 198L, 0L, "Sri Lanka", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 199L, 0L, "Sudan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 200L, 0L, "Suriname", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 201L, 0L, "Svalbard and JanMayen", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 202L, 0L, "Swaziland", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 203L, 0L, "Sweden", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 204L, 0L, "Switzerland", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 205L, 0L, "Syrian Arab Republic", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 206L, 0L, "Taiwan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 207L, 0L, "Tajikistan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 208L, 0L, "Tanzania", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 209L, 0L, "Thailand", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 210L, 0L, "Tokelau", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 211L, 0L, "Tonga", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "clientid", "countryname", "createby", "createdate", "isremoved", "note", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 212L, 0L, "Trinidad and Tobago", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 213L, 0L, "Tunisia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 214L, 0L, "Togo", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 215L, 0L, "Turkey", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 216L, 0L, "Turkmenistan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 217L, 0L, "Turks and Caicos Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 218L, 0L, "Tuvalu", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 219L, 0L, "Uganda", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 220L, 0L, "Ukraine", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 221L, 0L, "United Arab Emirates", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 222L, 0L, "United Kingdom", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 223L, 0L, "United States", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 224L, 0L, "Uruguay", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 225L, 0L, "Uzbekistan", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 226L, 0L, "Vanuatu", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 227L, 0L, "Vatican City State", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 228L, 0L, "Venezuela", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 229L, 0L, "Vietnam", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 230L, 0L, "Virgin Islands (British)", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 231L, 0L, "Virgin Islands (U.S.)", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 232L, 0L, "Wallis And Futuna Islands", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 233L, 0L, "Western Sahara", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 234L, 0L, "Yemen", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 235L, 0L, "Yugoslavia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 236L, 0L, "Zaire", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 237L, 0L, "Zambia", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 238L, 0L, "Zimbabwe", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 239L, 0L, "Guernsey", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 240L, 0L, "Malaga", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 241L, 0L, "Denmark", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null },
                    { 242L, 0L, "Jersey", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "IBloodTypes",
                columns: new[] { "id", "clientid", "createby", "createdate", "isremoved", "note", "typename", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 1L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "A+", null, null },
                    { 2L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "A-", null, null },
                    { 3L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "AB+", null, null },
                    { 4L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "AB-", null, null },
                    { 5L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "B+", null, null },
                    { 6L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "B-", null, null },
                    { 7L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "O+", null, null },
                    { 8L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "O-", null, null }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "id", "clientid", "createby", "createdate", "isremoved", "note", "typename", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { 1L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Clothing", null, null },
                    { 2L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Equipment", null, null },
                    { 3L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Medication", null, null }
                });

            migrationBuilder.InsertData(
                table: "Religions",
                columns: new[] { "id", "clientid", "createby", "createdate", "isremoved", "note", "religionname", "updatedby", "updateddate" },
                values: new object[] { 1L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Islam", null, null });

            migrationBuilder.InsertData(
                table: "Religions",
                columns: new[] { "id", "clientid", "createby", "createdate", "isremoved", "note", "religionname", "updatedby", "updateddate" },
                values: new object[] { 2L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Christian", null, null });

            migrationBuilder.InsertData(
                table: "Religions",
                columns: new[] { "id", "clientid", "createby", "createdate", "isremoved", "note", "religionname", "updatedby", "updateddate" },
                values: new object[] { 3L, 0L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Jewish", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmittedPatients");

            migrationBuilder.DropTable(
                name: "Aisles");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "IBloodTypes");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "OutPatients");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
