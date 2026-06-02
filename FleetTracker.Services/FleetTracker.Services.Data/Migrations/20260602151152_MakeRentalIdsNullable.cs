using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetTracker.Services.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeRentalIdsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgreements_Customers_CustomerId",
                table: "RentalAgreements");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgreements_Vehicles_VehicleId",
                table: "RentalAgreements");

            migrationBuilder.AlterColumn<Guid>(
                name: "VehicleId",
                table: "RentalAgreements",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "RentalAgreements",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgreements_Customers_CustomerId",
                table: "RentalAgreements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgreements_Vehicles_VehicleId",
                table: "RentalAgreements",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgreements_Customers_CustomerId",
                table: "RentalAgreements");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgreements_Vehicles_VehicleId",
                table: "RentalAgreements");

            migrationBuilder.AlterColumn<Guid>(
                name: "VehicleId",
                table: "RentalAgreements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "RentalAgreements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgreements_Customers_CustomerId",
                table: "RentalAgreements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgreements_Vehicles_VehicleId",
                table: "RentalAgreements",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}