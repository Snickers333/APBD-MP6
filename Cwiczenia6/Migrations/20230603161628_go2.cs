using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia6.Migrations
{
    /// <inheritdoc />
    public partial class go2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescribed_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 3, 18, 16, 28, 728, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.InsertData(
                table: "Prescribed_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 1, 1, "bierz az kopniesz w kalendarz", null });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 16, 28, 728, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 6, 3, 18, 16, 28, 728, DateTimeKind.Local).AddTicks(4308) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescribed_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 3, 18, 13, 50, 726, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.InsertData(
                table: "Prescribed_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 2, 1, "bierz az kopniesz w kalendarz", null });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 13, 50, 726, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 6, 3, 18, 13, 50, 726, DateTimeKind.Local).AddTicks(2787) });
        }
    }
}
