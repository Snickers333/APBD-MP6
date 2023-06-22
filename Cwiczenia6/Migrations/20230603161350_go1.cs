using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia6.Migrations
{
    /// <inheritdoc />
    public partial class go1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[] { 1, "Od niego przestaje bolec glowa", "Paracetamol", "Przeciwbólowe" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 3, 18, 13, 50, 726, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 13, 50, 726, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 6, 3, 18, 13, 50, 726, DateTimeKind.Local).AddTicks(2787) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[] { 2, "Od niego przestaje bolec glowa", "Paracetamol", "Przeciwbólowe" });

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
        }
    }
}
