using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MovieData.Migrations
{
    public partial class CompanyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    OfficeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    ImageAddress = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.OfficeId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyEmail",
                columns: table => new
                {
                    CompanyEmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(nullable: false),
                    OfficeRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEmail", x => x.CompanyEmailId);
                    table.ForeignKey(
                        name: "FK_CompanyEmail_Company_OfficeRefId",
                        column: x => x.OfficeRefId,
                        principalTable: "Company",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPhoneNumber",
                columns: table => new
                {
                    CompanyPhoneNumberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfficeRefId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPhoneNumber", x => x.CompanyPhoneNumberId);
                    table.ForeignKey(
                        name: "FK_CompanyPhoneNumber_Company_OfficeRefId",
                        column: x => x.OfficeRefId,
                        principalTable: "Company",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyEmail_OfficeRefId",
                table: "CompanyEmail",
                column: "OfficeRefId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPhoneNumber_OfficeRefId",
                table: "CompanyPhoneNumber",
                column: "OfficeRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyEmail");

            migrationBuilder.DropTable(
                name: "CompanyPhoneNumber");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
