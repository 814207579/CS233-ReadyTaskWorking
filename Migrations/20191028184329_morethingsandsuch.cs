using Microsoft.EntityFrameworkCore.Migrations;

namespace ReadyTask.Migrations
{
    public partial class morethingsandsuch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3c0fc752-17af-4aa2-ad4f-937aeed3f837");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0ba371a0-37c7-41f9-aac8-891131c2590b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e2fb0152-051b-4df8-9b19-48f853dc83bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4e3f2d1-ac14-4400-9e90-136242363fcd", "AQAAAAEAACcQAAAAENteEJAII9NgiTw3055CfVdV/VfkMsebE124HBvLywnGASxIKxez6861vqY/+v467w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "510f6bed-adcc-46ee-b0d2-e91c868b38e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "aa85c1c3-ca4c-4938-8c05-67984eb82a43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "28ac3802-318d-4ec7-90da-8a7f085d2ff4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7eca5229-ffd0-4675-b34e-899378a97e10", "AQAAAAEAACcQAAAAEJ3MFCyfsyZBb+5tYtIZub78Vc2ZncKLWjfbmmwICpaGfdvld56eAJ5SKuEkfkhC+A==" });
        }
    }
}
