using Microsoft.EntityFrameworkCore.Migrations;

namespace ReadyTask.Migrations
{
    public partial class AddedUserRollsWorking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "8e5f6782-f08c-4f5b-9b34-9611066240fa", "Admin", "ADMIN" },
                    { 2, "85ba82bc-4e54-4522-b8f5-277a39235a43", "Manager", "MANAGER" },
                    { 3, "e8d85f0f-aad4-43ee-acd9-4b8746be9656", "Dev", "DEV" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c64d406e-4fc1-4b75-9012-e1cee1a37794", "AQAAAAEAACcQAAAAEJGT7INGmhqim5onmrZZ+0DbV9X7ieaVG8CKhS3uaRtD6Fhigrqi3IJn/Uxwx+r0ZA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { 1, "8e5f6782-f08c-4f5b-9b34-9611066240fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { 2, "85ba82bc-4e54-4522-b8f5-277a39235a43" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { 3, "e8d85f0f-aad4-43ee-acd9-4b8746be9656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1aba8369-2348-43c0-b013-7f3e81bc31ac", "AQAAAAEAACcQAAAAEHQPKqoH16SzPfvTcD/KQA2Uix157BguSEaiZqas1DEWQ6F1DZ2EBZE4BJ+8fH7AxA==" });
        }
    }
}
