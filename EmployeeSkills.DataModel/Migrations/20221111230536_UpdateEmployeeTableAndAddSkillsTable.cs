using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeSkills.DbContext.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeTableAndAddSkillsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPositionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "SkillModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeModelSkillModel",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    SkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeModelSkillModel", x => new { x.EmployeesId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_EmployeeModelSkillModel_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeModelSkillModel_SkillModel_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "SkillModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeModelSkillModel_SkillsId",
                table: "EmployeeModelSkillModel",
                column: "SkillsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeModelSkillModel");

            migrationBuilder.DropTable(
                name: "SkillModel");

            migrationBuilder.AddColumn<int>(
                name: "CurrentPositionId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
