using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeSkills.DbContext.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyEmployeeSkillTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Employees_EmployeesId",
                table: "EmployeeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Skill_SkillsId",
                table: "EmployeeSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSkill",
                table: "EmployeeSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "Skills");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "EmployeeSkill",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "EmployeeSkill",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSkill_SkillsId",
                table: "EmployeeSkill",
                newName: "IX_EmployeeSkill_SkillId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmployeeSkill",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSkill",
                table: "EmployeeSkill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkill_EmployeeId",
                table: "EmployeeSkill",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Employees_EmployeeId",
                table: "EmployeeSkill",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Skills_SkillId",
                table: "EmployeeSkill",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Employees_EmployeeId",
                table: "EmployeeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Skills_SkillId",
                table: "EmployeeSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSkill",
                table: "EmployeeSkill");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeSkill_EmployeeId",
                table: "EmployeeSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmployeeSkill");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skill");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "EmployeeSkill",
                newName: "SkillsId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployeeSkill",
                newName: "EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSkill_SkillId",
                table: "EmployeeSkill",
                newName: "IX_EmployeeSkill_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSkill",
                table: "EmployeeSkill",
                columns: new[] { "EmployeesId", "SkillsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Employees_EmployeesId",
                table: "EmployeeSkill",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Skill_SkillsId",
                table: "EmployeeSkill",
                column: "SkillsId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
