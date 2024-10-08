using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StrengthEFcore.Migrations
{
    /// <inheritdoc />
    public partial class rebuildinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_ExerciseType_ExerciseTypeId",
                        column: x => x.ExerciseTypeId,
                        principalTable: "ExerciseType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workout_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseBout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    SetRepJson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseBout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseBout_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseBout_Workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Olivia Hernandez" },
                    { 2, "Jessica Garcia" },
                    { 3, "Sophia Martinez" },
                    { 4, "Michael Gonzalez" },
                    { 5, "Matthew Martin" },
                    { 6, "Alice Taylor" },
                    { 7, "Daniel Rodriguez" },
                    { 8, "Diana Williams" },
                    { 9, "Olivia Miller" },
                    { 10, "Matthew Johnson" },
                    { 11, "Jessica Miller" },
                    { 12, "Olivia Lopez" },
                    { 13, "John Johnson" },
                    { 14, "Emma Moore" },
                    { 15, "Jessica Smith" },
                    { 16, "Michael Rodriguez" },
                    { 17, "Michael Taylor" },
                    { 18, "Sarah Garcia" },
                    { 19, "Sarah Martinez" },
                    { 20, "Daniel Martinez" },
                    { 21, "Sarah Martin" },
                    { 22, "Jane Jackson" },
                    { 23, "Sophia Williams" },
                    { 24, "Alice Wilson" },
                    { 25, "Fiona Williams" },
                    { 26, "Ian Garcia" },
                    { 27, "Jane Smith" },
                    { 28, "Chris Johnson" },
                    { 29, "Alex Thomas" },
                    { 30, "George Lopez" },
                    { 31, "Michael Lopez" },
                    { 32, "David Anderson" },
                    { 33, "Olivia Wilson" },
                    { 34, "David Martin" },
                    { 35, "Jane Davis" },
                    { 36, "David Jackson" },
                    { 37, "Jane Martin" },
                    { 38, "Emma Gonzalez" },
                    { 39, "Emma Taylor" },
                    { 40, "Chris Jackson" },
                    { 41, "Diana Rodriguez" },
                    { 42, "George Martinez" },
                    { 43, "Fiona Jones" },
                    { 44, "Matthew Williams" },
                    { 45, "Ian Jones" },
                    { 46, "David Hernandez" },
                    { 47, "Alice Miller" },
                    { 48, "Fiona Martinez" },
                    { 49, "Michael Jackson" },
                    { 50, "Emma Smith" },
                    { 51, "David Lopez" },
                    { 52, "Hannah Johnson" },
                    { 53, "Olivia Gonzalez" },
                    { 54, "Jane Jones" },
                    { 55, "Sarah Davis" },
                    { 56, "Alice Jones" },
                    { 57, "Sarah Jones" },
                    { 58, "Emma Garcia" },
                    { 59, "Bob Moore" },
                    { 60, "Hannah Martin" },
                    { 61, "George Garcia" },
                    { 62, "Michael Moore" },
                    { 63, "Alice Rodriguez" },
                    { 64, "John Hernandez" },
                    { 65, "Ian Davis" },
                    { 66, "Jane Rodriguez" },
                    { 67, "Sophia Martin" },
                    { 68, "Daniel Hernandez" },
                    { 69, "Sarah Gonzalez" },
                    { 70, "Sophia Johnson" },
                    { 71, "Hannah Brown" },
                    { 72, "Jessica Davis" },
                    { 73, "Diana Anderson" },
                    { 74, "Sophia Rodriguez" },
                    { 75, "Bob Wilson" },
                    { 76, "Emma Rodriguez" },
                    { 77, "John Miller" },
                    { 78, "John Anderson" },
                    { 79, "Jane Johnson" },
                    { 80, "Fiona Martin" },
                    { 81, "Sophia Gonzalez" },
                    { 82, "Alex Jackson" },
                    { 83, "John Rodriguez" },
                    { 84, "Matthew Rodriguez" },
                    { 85, "Sarah Rodriguez" },
                    { 86, "John Gonzalez" },
                    { 87, "Diana Hernandez" },
                    { 88, "Ian Martinez" },
                    { 89, "George Hernandez" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_ExerciseTypeId",
                table: "Exercise",
                column: "ExerciseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseBout_ExerciseId",
                table: "ExerciseBout",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseBout_WorkoutId",
                table: "ExerciseBout",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_UserId",
                table: "Workout",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseBout");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "ExerciseType");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
