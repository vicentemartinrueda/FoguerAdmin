using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoguerAppApi.Migrations
{
    public partial class RelationshipBugFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Role_CreatorId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_Role_RoleId",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_RoleId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Role");

            migrationBuilder.AlterColumn<int>(
                name: "CreatorId",
                table: "Post",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Nif = table.Column<string>(nullable: true),
                    Activated = table.Column<bool>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreationDate", "DeleteDate", "Name", "Priority", "UpdateDate" },
                values: new object[] { 1, new DateTime(2020, 2, 29, 17, 39, 49, 148, DateTimeKind.Local).AddTicks(5833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", 10, new DateTime(2020, 2, 29, 17, 39, 49, 151, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreationDate", "DeleteDate", "Name", "Priority", "UpdateDate" },
                values: new object[] { 2, new DateTime(2020, 2, 29, 17, 39, 49, 151, DateTimeKind.Local).AddTicks(4046), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager", 1, new DateTime(2020, 2, 29, 17, 39, 49, 151, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Activated", "CreationDate", "DeleteDate", "Name", "Nif", "ReleaseDate", "RoleId", "Surname", "UpdateDate", "UserName" },
                values: new object[] { 2, true, new DateTime(2020, 2, 29, 17, 39, 49, 154, DateTimeKind.Local).AddTicks(1812), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe", "12345678Z", new DateTime(2020, 2, 29, 17, 39, 49, 154, DateTimeKind.Local).AddTicks(1775), 1, "Del Real Gama", new DateTime(2020, 2, 29, 17, 39, 49, 154, DateTimeKind.Local).AddTicks(1822), "user2" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Activated", "CreationDate", "DeleteDate", "Name", "Nif", "ReleaseDate", "RoleId", "Surname", "UpdateDate", "UserName" },
                values: new object[] { 1, true, new DateTime(2020, 2, 29, 17, 39, 49, 154, DateTimeKind.Local).AddTicks(477), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vicente", "53244606C", new DateTime(2020, 2, 29, 17, 39, 49, 153, DateTimeKind.Local).AddTicks(9063), 2, "Martín Rueda", new DateTime(2020, 2, 29, 17, 39, 49, 154, DateTimeKind.Local).AddTicks(1098), "santofrost" });

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_CreatorId",
                table: "Post",
                column: "CreatorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_CreatorId",
                table: "Post");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatorId",
                table: "Post",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleId",
                table: "Role",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Role_CreatorId",
                table: "Post",
                column: "CreatorId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Role_RoleId",
                table: "Role",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
