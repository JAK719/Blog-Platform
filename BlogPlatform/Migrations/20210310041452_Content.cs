using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class Content : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 23, 14, 52, 151, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 23, 14, 52, 154, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 23, 14, 52, 154, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 23, 14, 52, 154, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 23, 14, 52, 154, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 23, 14, 52, 154, DateTimeKind.Local).AddTicks(2965));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 20, 58, 49, 767, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1767));
        }
    }
}
