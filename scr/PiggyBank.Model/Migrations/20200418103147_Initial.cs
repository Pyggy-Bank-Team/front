using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PiggyBank.Model.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Pb");

            migrationBuilder.CreateTable(
                name: "Accounts",
                schema: "Pb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "Pb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    HexColor = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BalanceHistories",
                schema: "Pb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BalanceHistories_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "Pb",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                schema: "Pb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Shapshot = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: true),
                    AccountId = table.Column<int>(nullable: true),
                    PlanDate = table.Column<DateTime>(nullable: true),
                    From = table.Column<int>(nullable: true),
                    To = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "Pb",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "Pb",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BalanceHistories_AccountId",
                schema: "Pb",
                table: "BalanceHistories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_AccountId",
                schema: "Pb",
                table: "Operations",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_CategoryId",
                schema: "Pb",
                table: "Operations",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceHistories",
                schema: "Pb");

            migrationBuilder.DropTable(
                name: "Operations",
                schema: "Pb");

            migrationBuilder.DropTable(
                name: "Accounts",
                schema: "Pb");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Pb");
        }
    }
}
