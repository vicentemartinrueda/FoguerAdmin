using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoguerAppApi.Migrations
{
    public partial class AllTablesNeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComment_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostComment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proposal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proposal_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SharedFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uri = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SharedFile_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProposalComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<int>(nullable: false),
                    ProposalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProposalComment_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProposalComment_Proposal_ProposalId",
                        column: x => x.ProposalId,
                        principalTable: "Proposal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProposalOption",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: false),
                    ProposalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProposalOption_Proposal_ProposalId",
                        column: x => x.ProposalId,
                        principalTable: "Proposal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "CreationDate", "CreatorId", "DeleteDate", "PostId", "Text", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(5439), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Genial Post", new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(5831) },
                    { 2, new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(6271), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fantástico Post", new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(6295) }
                });

            migrationBuilder.InsertData(
                table: "Proposal",
                columns: new[] { "Id", "CreationDate", "CreatorId", "DeleteDate", "Subtitle", "Text", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(8594), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subtítulo 1", "Texto 1", "Color de las camisetas", new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(9089) },
                    { 2, new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(9546), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subtítulo 2", "Texto 2", "Título 2", new DateTime(2020, 8, 29, 19, 31, 52, 181, DateTimeKind.Local).AddTicks(9570) }
                });

            migrationBuilder.InsertData(
                table: "ProposalComment",
                columns: new[] { "Id", "CreationDate", "CreatorId", "DeleteDate", "ProposalId", "Text", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(1242), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Genial Proposal", new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(1632) },
                    { 2, new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(2046), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fantástico Proposal", new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(2071) }
                });

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

            migrationBuilder.InsertData(
                table: "ProposalOption",
                columns: new[] { "Id", "CreationDate", "DeleteDate", "ProposalId", "Text", "UpdateDate" },
                values: new object[] { 1, new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(3777), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Rosa", new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.InsertData(
                table: "ProposalOption",
                columns: new[] { "Id", "CreationDate", "DeleteDate", "ProposalId", "Text", "UpdateDate" },
                values: new object[] { 2, new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(4572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Azul", new DateTime(2020, 8, 29, 19, 31, 52, 182, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_CreatorId",
                table: "PostComment",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId",
                table: "PostComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposal_CreatorId",
                table: "Proposal",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProposalComment_CreatorId",
                table: "ProposalComment",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProposalComment_ProposalId",
                table: "ProposalComment",
                column: "ProposalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProposalOption_ProposalId",
                table: "ProposalOption",
                column: "ProposalId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedFile_CreatorId",
                table: "SharedFile",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "ProposalComment");

            migrationBuilder.DropTable(
                name: "ProposalOption");

            migrationBuilder.DropTable(
                name: "SharedFile");

            migrationBuilder.DropTable(
                name: "Proposal");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(3558), new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(4799), new DateTime(2020, 2, 29, 19, 26, 8, 691, DateTimeKind.Local).AddTicks(4824) });

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
    }
}
