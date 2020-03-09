using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoguerAppApi.Migrations
{
    public partial class DataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "CreatorId", "Subtitle", "Title", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(3558), 1, "Subtítulo 1", "Título 1", new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "CreatorId", "Subtitle", "Title", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(4799), 1, "Subtítulo 2", "Título 2", new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 685, DateTimeKind.Local).AddTicks(5459), new DateTime(2020, 2, 29, 19, 26, 8, 688, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 688, DateTimeKind.Local).AddTicks(3864), new DateTime(2020, 2, 29, 19, 26, 8, 688, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 690, DateTimeKind.Local).AddTicks(8502), new DateTime(2020, 2, 29, 19, 26, 8, 690, DateTimeKind.Local).AddTicks(7296), new DateTime(2020, 2, 29, 19, 26, 8, 690, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 690, DateTimeKind.Local).AddTicks(9811), new DateTime(2020, 2, 29, 19, 26, 8, 690, DateTimeKind.Local).AddTicks(9781), new DateTime(2020, 2, 29, 19, 26, 8, 690, DateTimeKind.Local).AddTicks(9822) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "CreatorId", "Subtitle", "Title", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(8687), 0, null, null, new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "CreatorId", "Subtitle", "Title", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 23, 1, 154, DateTimeKind.Local).AddTicks(322), 0, null, null, new DateTime(2020, 2, 29, 19, 23, 1, 154, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 23, 1, 148, DateTimeKind.Local).AddTicks(4541), new DateTime(2020, 2, 29, 19, 23, 1, 151, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 23, 1, 151, DateTimeKind.Local).AddTicks(3174), new DateTime(2020, 2, 29, 19, 23, 1, 151, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(5795), new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(4529), new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(7101), new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(7064), new DateTime(2020, 2, 29, 19, 23, 1, 153, DateTimeKind.Local).AddTicks(7112) });
        }
    }
}
