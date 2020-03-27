using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningSystem.Migrations
{
    public partial class migs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherProfile_Teachers_TeacherId",
                table: "TeacherProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherProfile",
                table: "TeacherProfile");

            migrationBuilder.RenameTable(
                name: "TeacherProfile",
                newName: "TeacherProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherProfile_TeacherId",
                table: "TeacherProfiles",
                newName: "IX_TeacherProfiles_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherProfiles",
                table: "TeacherProfiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherProfiles_Teachers_TeacherId",
                table: "TeacherProfiles",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherProfiles_Teachers_TeacherId",
                table: "TeacherProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherProfiles",
                table: "TeacherProfiles");

            migrationBuilder.RenameTable(
                name: "TeacherProfiles",
                newName: "TeacherProfile");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherProfiles_TeacherId",
                table: "TeacherProfile",
                newName: "IX_TeacherProfile_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherProfile",
                table: "TeacherProfile",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherProfile_Teachers_TeacherId",
                table: "TeacherProfile",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
