using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoFarmFood.Web.Migrations
{
    public partial class AddedConsumerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Consumers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Consumers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Consumers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_AddressId",
                table: "Consumers",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_Address_AddressId",
                table: "Consumers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_Address_AddressId",
                table: "Consumers");

            migrationBuilder.DropIndex(
                name: "IX_Consumers_AddressId",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Consumers");
        }
    }
}
