using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class SeedDataandRemoveGroupFromMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 1, "Group 1" });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 2, "Group 2" });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 3, "Group 3" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "GroupId", "MessageText", "PostDate" },
                values: new object[] { 1, 1, "Hello World", new DateTime(2010, 1, 1, 8, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "GroupId", "MessageText", "PostDate" },
                values: new object[] { 2, 2, "Whattup World", new DateTime(2011, 2, 10, 8, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "GroupId", "MessageText", "PostDate" },
                values: new object[] { 3, 3, "Hi There World", new DateTime(2012, 3, 15, 8, 0, 15, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 3);
        }
    }
}
