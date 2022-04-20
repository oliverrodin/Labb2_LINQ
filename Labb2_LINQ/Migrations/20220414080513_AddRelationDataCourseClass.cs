using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2_LINQ.Migrations
{
    public partial class AddRelationDataCourseClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Classes_ClassesId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Courses_CoursesId",
                table: "ClassCourse");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "ClassCourse",
                newName: "ClassId");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "ClassCourse",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassCourse_CoursesId",
                table: "ClassCourse",
                newName: "IX_ClassCourse_ClassId");

            migrationBuilder.InsertData(
                table: "ClassCourse",
                columns: new[] { "ClassId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 4 },
                    { 3, 5 },
                    { 4, 5 },
                    { 3, 6 },
                    { 4, 6 },
                    { 1, 7 },
                    { 4, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 4, 9 },
                    { 1, 10 },
                    { 2, 10 },
                    { 4, 10 },
                    { 1, 11 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Classes_ClassId",
                table: "ClassCourse",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Courses_CourseId",
                table: "ClassCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Classes_ClassId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Courses_CourseId",
                table: "ClassCourse");

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourse",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "ClassCourse",
                newName: "CoursesId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "ClassCourse",
                newName: "ClassesId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassCourse_ClassId",
                table: "ClassCourse",
                newName: "IX_ClassCourse_CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Classes_ClassesId",
                table: "ClassCourse",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Courses_CoursesId",
                table: "ClassCourse",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
