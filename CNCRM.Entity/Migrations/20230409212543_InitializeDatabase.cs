using Microsoft.EntityFrameworkCore.Migrations;

namespace CNCRM.Entity.Migrations
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    City = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    SectorName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    TaxOffice = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserComputers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComputers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BackupUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Cpu = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Ram = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DiskModel = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DiskCapacity = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    TotalDiskSlot = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    RaidType = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    RaidUpTo = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackupUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackupUnits_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Cpu = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Ram = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DiskType = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Gpu = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    OsType = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Firewalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LicenseStartDate = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LicenseEndDate = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LicenseModelName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firewalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Firewalls_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Cpu = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Ram = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DiskType = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    OsPlatform = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    OsVersion = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    OsLicenseNumber = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    VirtualizationSystemPlatform = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    TotalCpuSlot = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    TotalRamSlot = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    RamUpTo = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    CanVpnAccess = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackupUnits_CustomerId",
                table: "BackupUnits",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_CustomerId",
                table: "Computers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Firewalls_CustomerId",
                table: "Firewalls",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_CustomerId",
                table: "Servers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerId",
                table: "Users",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackupUnits");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Firewalls");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "UserComputers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
