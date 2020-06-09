using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DADLHumanResources.Data.Migrations
{
    public partial class SeedIdentityUser_Version_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("6d6c7751-92b7-4d32-ac9c-ca9ed043e2df"), "16107daa-87f5-4806-9eb1-f9a2041a3a27", "Administrator Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("6d6c7751-92b7-4d32-ac9c-ca9ed043e2df"), new Guid("bf5e741c-f4e3-45bc-96dd-b1e925cbf30d") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6d6c7751-92b7-4d32-ac9c-ca9ed043e2df"), 0, "0ad248be-874d-48b2-a40f-ade6222b3616", new DateTime(1991, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranphandainam@gmail.com", true, "Tran", "Nam", false, null, "tranphandainam@gmail.com", "admin", "AQAAAAEAACcQAAAAEAkvWDhhk4m5xK2AmHxC5jnVWswrFa8JPw+fJ/uge745d0XhIi538VgH8FUj0si3Bw==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d6c7751-92b7-4d32-ac9c-ca9ed043e2df"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("6d6c7751-92b7-4d32-ac9c-ca9ed043e2df"), new Guid("bf5e741c-f4e3-45bc-96dd-b1e925cbf30d") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d6c7751-92b7-4d32-ac9c-ca9ed043e2df"));
        }
    }
}
