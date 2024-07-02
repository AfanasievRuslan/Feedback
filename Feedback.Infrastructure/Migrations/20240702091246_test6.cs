using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Feedback.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FeedbackItems",
                table: "FeedbackItems");

            migrationBuilder.RenameTable(
                name: "FeedbackItems",
                newName: "FeedbackDb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeedbackDb",
                table: "FeedbackDb",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FeedbackDb",
                table: "FeedbackDb");

            migrationBuilder.RenameTable(
                name: "FeedbackDb",
                newName: "FeedbackItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeedbackItems",
                table: "FeedbackItems",
                column: "Id");
        }
    }
}
