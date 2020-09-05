using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoguerAppApi.Migrations
{
    public partial class AddVoters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OptionUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    OptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionUser_ProposalOption_OptionId",
                        column: x => x.OptionId,
                        principalTable: "ProposalOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OptionUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OptionUser_OptionId",
                table: "OptionUser",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionUser_UserId",
                table: "OptionUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OptionUser");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(2890), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(3736), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(5439), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(6271), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Proposal",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(8594), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Proposal",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(9546), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "ProposalComment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(1242), new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "ProposalComment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(2046), new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "ProposalOption",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(3777), new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "ProposalOption",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(4572), new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 176, DateTimeKind.Local).AddTicks(665), new DateTime(2020, 8, 29, 19, 31, 52, 179, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 179, DateTimeKind.Local).AddTicks(857), new DateTime(2020, 8, 29, 19, 31, 52, 179, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 180, DateTimeKind.Local).AddTicks(9510), new DateTime(2020, 8, 29, 19, 31, 52, 180, DateTimeKind.Local).AddTicks(8754), new DateTime(2020, 8, 29, 19, 31, 52, 180, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ReleaseDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(417), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(384), new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(430) });
        }
    }
}
