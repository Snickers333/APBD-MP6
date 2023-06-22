using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia6.Migrations
{
    /// <inheritdoc />
    public partial class go : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescribed_Medicaments_Medics_IdMedicament",
                table: "Prescribed_Medicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medics",
                table: "Medics");

            migrationBuilder.RenameTable(
                name: "Medics",
                newName: "Medicaments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicaments",
                table: "Medicaments",
                column: "IdMedicament");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 3, 18, 12, 5, 874, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 5, 874, DateTimeKind.Local).AddTicks(5511), new DateTime(2023, 6, 3, 18, 12, 5, 874, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.AddForeignKey(
                name: "FK_Prescribed_Medicaments_Medicaments_IdMedicament",
                table: "Prescribed_Medicaments",
                column: "IdMedicament",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescribed_Medicaments_Medicaments_IdMedicament",
                table: "Prescribed_Medicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicaments",
                table: "Medicaments");

            migrationBuilder.RenameTable(
                name: "Medicaments",
                newName: "Medics");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medics",
                table: "Medics",
                column: "IdMedicament");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 3, 17, 30, 34, 32, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 17, 30, 34, 33, DateTimeKind.Local).AddTicks(24), new DateTime(2023, 6, 3, 17, 30, 34, 33, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.AddForeignKey(
                name: "FK_Prescribed_Medicaments_Medics_IdMedicament",
                table: "Prescribed_Medicaments",
                column: "IdMedicament",
                principalTable: "Medics",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
