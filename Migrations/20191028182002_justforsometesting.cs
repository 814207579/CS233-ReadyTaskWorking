using Microsoft.EntityFrameworkCore.Migrations;

namespace ReadyTask.Migrations
{
    public partial class justforsometesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6555400d-bed4-4c59-81af-e36eae5657fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "408e15ad-0bb0-4066-aacf-9eb6e6ea721a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d7354c7c-0948-4d8c-9887-55b3f7166c05");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0c8a597-693d-4a54-a915-3f7552536615", "AQAAAAEAACcQAAAAEIepqaZADZZ2wskuIj8oi0oD0ywRwopU5WYi0/F2Ro6yHyHY2FPEsjtPJ5fyabsQgA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8e5f6782-f08c-4f5b-9b34-9611066240fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "85ba82bc-4e54-4522-b8f5-277a39235a43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e8d85f0f-aad4-43ee-acd9-4b8746be9656");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c64d406e-4fc1-4b75-9012-e1cee1a37794", "AQAAAAEAACcQAAAAEJGT7INGmhqim5onmrZZ+0DbV9X7ieaVG8CKhS3uaRtD6Fhigrqi3IJn/Uxwx+r0ZA==" });
        }
    }
}
