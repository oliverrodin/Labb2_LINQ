using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2_LINQ.Migrations
{
    public partial class AddRealtionDataTeacherCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Courses_CoursesId",
                table: "CourseTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Teachers_TeachersId",
                table: "CourseTeacher");

            migrationBuilder.RenameColumn(
                name: "TeachersId",
                table: "CourseTeacher",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseTeacher",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTeacher_TeachersId",
                table: "CourseTeacher",
                newName: "IX_CourseTeacher_CourseId");

            migrationBuilder.InsertData(
                table: "CourseTeacher",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[,]
                {
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 4 },
                    { 6, 4 },
                    { 5, 5 },
                    { 6, 5 },
                    { 7, 5 },
                    { 7, 6 },
                    { 8, 6 },
                    { 9, 6 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Courses_CourseId",
                table: "CourseTeacher",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Teachers_TeacherId",
                table: "CourseTeacher",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Courses_CourseId",
                table: "CourseTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Teachers_TeacherId",
                table: "CourseTeacher");

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseTeacher",
                newName: "TeachersId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "CourseTeacher",
                newName: "CoursesId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTeacher_CourseId",
                table: "CourseTeacher",
                newName: "IX_CourseTeacher_TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Courses_CoursesId",
                table: "CourseTeacher",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Teachers_TeachersId",
                table: "CourseTeacher",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
