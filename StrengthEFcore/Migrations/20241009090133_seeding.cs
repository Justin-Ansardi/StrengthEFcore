using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StrengthEFcore.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ian Lopez" },
                    { 2, "David Lopez" },
                    { 3, "John Jones" },
                    { 4, "Bob Wilson" },
                    { 5, "Bob Rodriguez" },
                    { 6, "Diana Johnson" },
                    { 7, "Jessica Davis" },
                    { 8, "Olivia Jackson" },
                    { 9, "Olivia Hernandez" },
                    { 10, "Alex Jones" },
                    { 11, "Emma Johnson" },
                    { 12, "Alice Smith" },
                    { 13, "Daniel Jackson" },
                    { 14, "Sarah Davis" },
                    { 15, "Jessica Garcia" },
                    { 16, "John Taylor" },
                    { 17, "Diana Hernandez" },
                    { 18, "George Garcia" },
                    { 19, "Chris Smith" },
                    { 20, "George Martin" },
                    { 21, "Hannah Jones" },
                    { 22, "Michael Rodriguez" },
                    { 23, "Alice Martin" },
                    { 24, "Hannah Brown" },
                    { 25, "Michael Jackson" },
                    { 26, "Emma Thomas" },
                    { 27, "Sarah Garcia" },
                    { 28, "Sarah Jones" },
                    { 29, "Jane Rodriguez" },
                    { 30, "Chris Miller" },
                    { 31, "Diana Wilson" },
                    { 32, "David Taylor" },
                    { 33, "David Martinez" },
                    { 34, "Alice Moore" },
                    { 35, "Jessica Anderson" },
                    { 36, "David Anderson" },
                    { 37, "Sarah Wilson" },
                    { 38, "Sophia Anderson" },
                    { 39, "Bob Lopez" },
                    { 40, "Fiona Rodriguez" },
                    { 41, "Chris Jones" },
                    { 42, "Sarah Hernandez" },
                    { 43, "Michael Garcia" },
                    { 44, "Olivia Moore" },
                    { 45, "Sophia Williams" },
                    { 46, "Fiona Jackson" },
                    { 47, "Olivia Rodriguez" },
                    { 48, "Hannah Wilson" },
                    { 49, "Sophia Smith" },
                    { 50, "Sarah Martin" },
                    { 51, "Matthew Martinez" },
                    { 52, "Alice Rodriguez" },
                    { 53, "Daniel Miller" },
                    { 54, "Daniel Wilson" },
                    { 55, "Fiona Anderson" },
                    { 56, "Michael Jones" },
                    { 57, "Ian Garcia" },
                    { 58, "Bob Miller" },
                    { 59, "Olivia Lopez" },
                    { 60, "Alice Williams" },
                    { 61, "Daniel Martinez" },
                    { 62, "Olivia Johnson" },
                    { 63, "Hannah Moore" },
                    { 64, "David Thomas" },
                    { 65, "George Gonzalez" },
                    { 66, "Hannah Lopez" },
                    { 67, "Emma Lopez" },
                    { 68, "Sophia Hernandez" },
                    { 69, "Alice Taylor" },
                    { 70, "Sophia Martin" },
                    { 71, "David Rodriguez" },
                    { 72, "Michael Davis" },
                    { 73, "George Hernandez" },
                    { 74, "Daniel Gonzalez" },
                    { 75, "Olivia Miller" },
                    { 76, "Michael Gonzalez" },
                    { 77, "Hannah Williams" },
                    { 78, "Alex Brown" },
                    { 79, "George Taylor" },
                    { 80, "Emma Gonzalez" },
                    { 81, "Sophia Taylor" },
                    { 82, "Olivia Jones" },
                    { 83, "Bob Hernandez" },
                    { 84, "Alex Davis" },
                    { 85, "Alice Hernandez" },
                    { 86, "Emma Jackson" },
                    { 87, "Daniel Hernandez" },
                    { 88, "Olivia Martin" },
                    { 89, "John Wilson" },
                    { 90, "Fiona Hernandez" }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "DateTime", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1815), "Ian Lopez's 9 session", 1 },
                    { 2, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1842), "David Lopez's 9 session", 2 },
                    { 3, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1847), "John Jones's 9 session", 3 },
                    { 4, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1851), "Bob Wilson's 9 session", 4 },
                    { 5, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1855), "Bob Rodriguez's 9 session", 5 },
                    { 6, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1892), "Diana Johnson's 9 session", 6 },
                    { 7, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1896), "Jessica Davis's 9 session", 7 },
                    { 8, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1900), "Olivia Jackson's 9 session", 8 },
                    { 9, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1903), "Olivia Hernandez's 9 session", 9 },
                    { 10, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1907), "Alex Jones's 9 session", 10 },
                    { 11, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1912), "Emma Johnson's 9 session", 11 },
                    { 12, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1916), "Alice Smith's 9 session", 12 },
                    { 13, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1919), "Daniel Jackson's 9 session", 13 },
                    { 14, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1923), "Sarah Davis's 9 session", 14 },
                    { 15, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1927), "Jessica Garcia's 9 session", 15 },
                    { 16, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1931), "John Taylor's 9 session", 16 },
                    { 17, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1935), "Diana Hernandez's 9 session", 17 },
                    { 18, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1939), "George Garcia's 9 session", 18 },
                    { 19, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1943), "Chris Smith's 9 session", 19 },
                    { 20, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1946), "George Martin's 9 session", 20 },
                    { 21, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1950), "Hannah Jones's 9 session", 21 },
                    { 22, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1954), "Michael Rodriguez's 9 session", 22 },
                    { 23, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1957), "Alice Martin's 9 session", 23 },
                    { 24, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1961), "Hannah Brown's 9 session", 24 },
                    { 25, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1965), "Michael Jackson's 9 session", 25 },
                    { 26, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1969), "Emma Thomas's 9 session", 26 },
                    { 27, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1972), "Sarah Garcia's 9 session", 27 },
                    { 28, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1976), "Sarah Jones's 9 session", 28 },
                    { 29, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1979), "Jane Rodriguez's 9 session", 29 },
                    { 30, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1983), "Chris Miller's 9 session", 30 },
                    { 31, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1986), "Diana Wilson's 9 session", 31 },
                    { 32, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1990), "David Taylor's 9 session", 32 },
                    { 33, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1994), "David Martinez's 9 session", 33 },
                    { 34, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(1998), "Alice Moore's 9 session", 34 },
                    { 35, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2002), "Jessica Anderson's 9 session", 35 },
                    { 36, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2006), "David Anderson's 9 session", 36 },
                    { 37, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2010), "Sarah Wilson's 9 session", 37 },
                    { 38, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2013), "Sophia Anderson's 9 session", 38 },
                    { 39, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2017), "Bob Lopez's 9 session", 39 },
                    { 40, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2020), "Fiona Rodriguez's 9 session", 40 },
                    { 41, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2024), "Chris Jones's 9 session", 41 },
                    { 42, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2028), "Sarah Hernandez's 9 session", 42 },
                    { 43, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2031), "Michael Garcia's 9 session", 43 },
                    { 44, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2035), "Olivia Moore's 9 session", 44 },
                    { 45, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2039), "Sophia Williams's 9 session", 45 },
                    { 46, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2042), "Fiona Jackson's 9 session", 46 },
                    { 47, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2046), "Olivia Rodriguez's 9 session", 47 },
                    { 48, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2050), "Hannah Wilson's 9 session", 48 },
                    { 49, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2053), "Sophia Smith's 9 session", 49 },
                    { 50, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2089), "Sarah Martin's 9 session", 50 },
                    { 51, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2094), "Matthew Martinez's 9 session", 51 },
                    { 52, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2097), "Alice Rodriguez's 9 session", 52 },
                    { 53, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2101), "Daniel Miller's 9 session", 53 },
                    { 54, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2105), "Daniel Wilson's 9 session", 54 },
                    { 55, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2109), "Fiona Anderson's 9 session", 55 },
                    { 56, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2112), "Michael Jones's 9 session", 56 },
                    { 57, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2116), "Ian Garcia's 9 session", 57 },
                    { 58, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2120), "Bob Miller's 9 session", 58 },
                    { 59, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2123), "Olivia Lopez's 9 session", 59 },
                    { 60, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2127), "Alice Williams's 9 session", 60 },
                    { 61, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2130), "Daniel Martinez's 9 session", 61 },
                    { 62, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2135), "Olivia Johnson's 9 session", 62 },
                    { 63, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2138), "Hannah Moore's 9 session", 63 },
                    { 64, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2142), "David Thomas's 9 session", 64 },
                    { 65, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2146), "George Gonzalez's 9 session", 65 },
                    { 66, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2150), "Hannah Lopez's 9 session", 66 },
                    { 67, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2154), "Emma Lopez's 9 session", 67 },
                    { 68, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2157), "Sophia Hernandez's 9 session", 68 },
                    { 69, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2161), "Alice Taylor's 9 session", 69 },
                    { 70, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2165), "Sophia Martin's 9 session", 70 },
                    { 71, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2169), "David Rodriguez's 9 session", 71 },
                    { 72, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2172), "Michael Davis's 9 session", 72 },
                    { 73, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2176), "George Hernandez's 9 session", 73 },
                    { 74, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2180), "Daniel Gonzalez's 9 session", 74 },
                    { 75, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2183), "Olivia Miller's 9 session", 75 },
                    { 76, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2186), "Michael Gonzalez's 9 session", 76 },
                    { 77, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2190), "Hannah Williams's 9 session", 77 },
                    { 78, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2193), "Alex Brown's 9 session", 78 },
                    { 79, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2197), "George Taylor's 9 session", 79 },
                    { 80, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2201), "Emma Gonzalez's 9 session", 80 },
                    { 81, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2205), "Sophia Taylor's 9 session", 81 },
                    { 82, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2208), "Olivia Jones's 9 session", 82 },
                    { 83, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2211), "Bob Hernandez's 9 session", 83 },
                    { 84, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2215), "Alex Davis's 9 session", 84 },
                    { 85, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2219), "Alice Hernandez's 9 session", 85 },
                    { 86, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2222), "Emma Jackson's 9 session", 86 },
                    { 87, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2226), "Daniel Hernandez's 9 session", 87 },
                    { 88, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2229), "Olivia Martin's 9 session", 88 },
                    { 89, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2233), "John Wilson's 9 session", 89 },
                    { 90, new DateTime(2024, 10, 9, 5, 1, 33, 18, DateTimeKind.Local).AddTicks(2237), "Fiona Hernandez's 9 session", 90 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseBout",
                columns: new[] { "Id", "Exercise", "SetReps", "WorkoutId" },
                values: new object[,]
                {
                    { 1, "Powerclean", "[]", 1 },
                    { 2, "Squat", "[]", 2 },
                    { 3, "OverHeadPress", "[1]", 3 },
                    { 4, "Squat", "[]", 4 },
                    { 5, "OverHeadPress", "[1,1,1,1]", 5 },
                    { 6, "Squat", "[4,0,1,0]", 6 },
                    { 7, "Deadlift", "[0]", 7 },
                    { 8, "Squat", "[2,2]", 8 },
                    { 9, "Powerclean", "[3,3,4]", 9 },
                    { 10, "Deadlift", "[2,4]", 10 },
                    { 11, "Deadlift", "[3]", 11 },
                    { 12, "OverHeadPress", "[0,3,2]", 12 },
                    { 13, "Squat", "[2]", 13 },
                    { 14, "Deadlift", "[3,4]", 14 },
                    { 15, "Squat", "[3]", 15 },
                    { 16, "Powerclean", "[]", 16 },
                    { 17, "Squat", "[1,3,0]", 17 },
                    { 18, "OverHeadPress", "[0]", 18 },
                    { 19, "OverHeadPress", "[0,4,1]", 19 },
                    { 20, "Powerclean", "[4]", 20 },
                    { 21, "Squat", "[0,4]", 21 },
                    { 22, "Deadlift", "[4]", 22 },
                    { 23, "Squat", "[3,3,3]", 23 },
                    { 24, "Powerclean", "[1,2,0,1]", 24 },
                    { 25, "Deadlift", "[3]", 25 },
                    { 26, "BenchPress", "[1,3,2,0]", 26 },
                    { 27, "Deadlift", "[1,1]", 27 },
                    { 28, "OverHeadPress", "[3,3]", 28 },
                    { 29, "Deadlift", "[3,4]", 29 },
                    { 30, "Squat", "[4,4]", 30 },
                    { 31, "Deadlift", "[2,4,0,2]", 31 },
                    { 32, "Powerclean", "[2,1]", 32 },
                    { 33, "Squat", "[4,4]", 33 },
                    { 34, "Deadlift", "[2,4]", 34 },
                    { 35, "BenchPress", "[]", 35 },
                    { 36, "BenchPress", "[3,3]", 36 },
                    { 37, "Powerclean", "[]", 37 },
                    { 38, "BenchPress", "[2]", 38 },
                    { 39, "Squat", "[]", 39 },
                    { 40, "OverHeadPress", "[2]", 40 },
                    { 41, "Powerclean", "[0]", 41 },
                    { 42, "BenchPress", "[3,4]", 42 },
                    { 43, "OverHeadPress", "[1,0,1,2]", 43 },
                    { 44, "OverHeadPress", "[1,2]", 44 },
                    { 45, "OverHeadPress", "[0,1,4]", 45 },
                    { 46, "BenchPress", "[1]", 46 },
                    { 47, "BenchPress", "[]", 47 },
                    { 48, "Powerclean", "[]", 48 },
                    { 49, "Squat", "[1]", 49 },
                    { 50, "BenchPress", "[1]", 50 },
                    { 51, "Deadlift", "[2]", 51 },
                    { 52, "Deadlift", "[3]", 52 },
                    { 53, "Deadlift", "[3]", 53 },
                    { 54, "OverHeadPress", "[4,0]", 54 },
                    { 55, "OverHeadPress", "[]", 55 },
                    { 56, "Powerclean", "[4,1,4]", 56 },
                    { 57, "OverHeadPress", "[1,4,0]", 57 },
                    { 58, "Deadlift", "[4]", 58 },
                    { 59, "BenchPress", "[4]", 59 },
                    { 60, "OverHeadPress", "[]", 60 },
                    { 61, "Deadlift", "[1]", 61 },
                    { 62, "OverHeadPress", "[4,4,4]", 62 },
                    { 63, "BenchPress", "[3,0,2]", 63 },
                    { 64, "Squat", "[2]", 64 },
                    { 65, "Deadlift", "[1,2]", 65 },
                    { 66, "Deadlift", "[1,4,2,3]", 66 },
                    { 67, "Squat", "[2,2,1]", 67 },
                    { 68, "BenchPress", "[]", 68 },
                    { 69, "Squat", "[3,1,3]", 69 },
                    { 70, "Squat", "[4,4]", 70 },
                    { 71, "Powerclean", "[4,0,0,4]", 71 },
                    { 72, "BenchPress", "[1,2,3]", 72 },
                    { 73, "Powerclean", "[4,3]", 73 },
                    { 74, "OverHeadPress", "[2,1,3]", 74 },
                    { 75, "Squat", "[1,0,0]", 75 },
                    { 76, "BenchPress", "[]", 76 },
                    { 77, "OverHeadPress", "[4,4,2,3]", 77 },
                    { 78, "BenchPress", "[2,0,3]", 78 },
                    { 79, "BenchPress", "[3,2]", 79 },
                    { 80, "OverHeadPress", "[]", 80 },
                    { 81, "Deadlift", "[4]", 81 },
                    { 82, "Squat", "[]", 82 },
                    { 83, "Deadlift", "[]", 83 },
                    { 84, "Deadlift", "[4]", 84 },
                    { 85, "OverHeadPress", "[]", 85 },
                    { 86, "BenchPress", "[2,4,0]", 86 },
                    { 87, "Powerclean", "[0,1]", 87 },
                    { 88, "Squat", "[1,4,2,0]", 88 },
                    { 89, "Squat", "[0,4,1]", 89 },
                    { 90, "OverHeadPress", "[4,1]", 90 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ExerciseBout",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);
        }
    }
}
