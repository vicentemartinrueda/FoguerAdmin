using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoguerAppApi.Migrations
{
    public partial class PhotoIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Photo",
                table: "Proposal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Photo",
                table: "Post",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(4537), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(5514), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(7257), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(8046), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Proposal",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(443), new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Proposal",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(1246), new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "ProposalComment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(2979), new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "ProposalComment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(3703), new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "ProposalOption",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(5412), new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "ProposalOption",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(6184), new DateTime(2020, 9, 5, 18, 50, 18, 258, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 251, DateTimeKind.Local).AddTicks(8496), new DateTime(2020, 9, 5, 18, 50, 18, 255, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 255, DateTimeKind.Local).AddTicks(734), new DateTime(2020, 9, 5, 18, 50, 18, 255, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(1094), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(347), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(1979), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(1947), new DateTime(2020, 9, 5, 18, 50, 18, 257, DateTimeKind.Local).AddTicks(1991) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Proposal");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Post");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(2832), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(3686), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(5368), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(6157), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Proposal",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(8565), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Proposal",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(9378), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "ProposalComment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(1027), new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "ProposalComment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(1868), new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "ProposalOption",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(3484), new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "ProposalOption",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(4258), new DateTime(2020, 9, 5, 2, 49, 49, 377, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 371, DateTimeKind.Local).AddTicks(1403), new DateTime(2020, 9, 5, 2, 49, 49, 374, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 374, DateTimeKind.Local).AddTicks(1375), new DateTime(2020, 9, 5, 2, 49, 49, 374, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 375, DateTimeKind.Local).AddTicks(9457), new DateTime(2020, 9, 5, 2, 49, 49, 375, DateTimeKind.Local).AddTicks(8694), new DateTime(2020, 9, 5, 2, 49, 49, 375, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(379), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(347), new DateTime(2020, 9, 5, 2, 49, 49, 376, DateTimeKind.Local).AddTicks(391) });
        }
    }
}
