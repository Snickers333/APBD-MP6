using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia6.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicament_Medics_IdMedicament",
                table: "Prescription_Medicament");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicament_prescriptions_IdPrescription",
                table: "Prescription_Medicament");

            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_Doctors_IdDoctor",
                table: "prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_Patients_IdPatient",
                table: "prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prescriptions",
                table: "prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescription_Medicament",
                table: "Prescription_Medicament");

            migrationBuilder.RenameTable(
                name: "prescriptions",
                newName: "Prescriptions");

            migrationBuilder.RenameTable(
                name: "Prescription_Medicament",
                newName: "Prescribed_Medicaments");

            migrationBuilder.RenameIndex(
                name: "IX_prescriptions_IdPatient",
                table: "Prescriptions",
                newName: "IX_Prescriptions_IdPatient");

            migrationBuilder.RenameIndex(
                name: "IX_prescriptions_IdDoctor",
                table: "Prescriptions",
                newName: "IX_Prescriptions_IdDoctor");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "Prescribed_Medicaments",
                newName: "IX_Prescribed_Medicaments_IdPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions",
                column: "IdPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescribed_Medicaments",
                table: "Prescribed_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Prescribed_Medicaments_Prescriptions_IdPrescription",
                table: "Prescribed_Medicaments",
                column: "IdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_IdDoctor",
                table: "Prescriptions",
                column: "IdDoctor",
                principalTable: "Doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_IdPatient",
                table: "Prescriptions",
                column: "IdPatient",
                principalTable: "Patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescribed_Medicaments_Medics_IdMedicament",
                table: "Prescribed_Medicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescribed_Medicaments_Prescriptions_IdPrescription",
                table: "Prescribed_Medicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_IdDoctor",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_IdPatient",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescribed_Medicaments",
                table: "Prescribed_Medicaments");

            migrationBuilder.RenameTable(
                name: "Prescriptions",
                newName: "prescriptions");

            migrationBuilder.RenameTable(
                name: "Prescribed_Medicaments",
                newName: "Prescription_Medicament");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_IdPatient",
                table: "prescriptions",
                newName: "IX_prescriptions_IdPatient");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_IdDoctor",
                table: "prescriptions",
                newName: "IX_prescriptions_IdDoctor");

            migrationBuilder.RenameIndex(
                name: "IX_Prescribed_Medicaments_IdPrescription",
                table: "Prescription_Medicament",
                newName: "IX_Prescription_Medicament_IdPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prescriptions",
                table: "prescriptions",
                column: "IdPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescription_Medicament",
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 3, 16, 14, 19, 253, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 14, 19, 253, DateTimeKind.Local).AddTicks(344), new DateTime(2023, 6, 3, 16, 14, 19, 253, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicament_Medics_IdMedicament",
                table: "Prescription_Medicament",
                column: "IdMedicament",
                principalTable: "Medics",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicament_prescriptions_IdPrescription",
                table: "Prescription_Medicament",
                column: "IdPrescription",
                principalTable: "prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_Doctors_IdDoctor",
                table: "prescriptions",
                column: "IdDoctor",
                principalTable: "Doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_Patients_IdPatient",
                table: "prescriptions",
                column: "IdPatient",
                principalTable: "Patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
