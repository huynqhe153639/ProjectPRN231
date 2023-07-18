using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateAPI.Migrations
{
    public partial class AddForeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignment_AssignmentId",
                table: "StudentAssignment",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttendance_QuizId",
                table: "QuizAttendance",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_CourseId",
                table: "Quiz",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuizId",
                table: "Question",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrollment_CourseId",
                table: "CourseEnrollment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_CourseId",
                table: "Assignment",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Course_CourseId",
                table: "Assignment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEnrollment_Course_CourseId",
                table: "CourseEnrollment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Quiz_QuizId",
                table: "Question",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "QuizId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quiz_Course_CourseId",
                table: "Quiz",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttendance_Quiz_QuizId",
                table: "QuizAttendance",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "QuizId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAssignment_Assignment_AssignmentId",
                table: "StudentAssignment",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Course_CourseId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseEnrollment_Course_CourseId",
                table: "CourseEnrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Quiz_QuizId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Quiz_Course_CourseId",
                table: "Quiz");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttendance_Quiz_QuizId",
                table: "QuizAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAssignment_Assignment_AssignmentId",
                table: "StudentAssignment");

            migrationBuilder.DropIndex(
                name: "IX_StudentAssignment_AssignmentId",
                table: "StudentAssignment");

            migrationBuilder.DropIndex(
                name: "IX_QuizAttendance_QuizId",
                table: "QuizAttendance");

            migrationBuilder.DropIndex(
                name: "IX_Quiz_CourseId",
                table: "Quiz");

            migrationBuilder.DropIndex(
                name: "IX_Question_QuizId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_CourseEnrollment_CourseId",
                table: "CourseEnrollment");

            migrationBuilder.DropIndex(
                name: "IX_Assignment_CourseId",
                table: "Assignment");
        }
    }
}
