using Cwiczenia6.Data;
using Cwiczenia6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Cwiczenia6.Services
{
    public interface IPrescirptionsService
    {
        Task<IEnumerable<PrescriptionDTO>> GetPrescription(int id);
    }
    public class PrescriptionsService : IPrescirptionsService
    {
        private readonly DataContext _context;
        public PrescriptionsService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PrescriptionDTO>> GetPrescription(int id)
        {
            var prescriptionFound = await _context
                .Prescriptions
                .Include(p => p.Doctor)
                .Include(p => p.Patient)
                .Include(p => p.Prescribed_Medications)
                .ThenInclude(pm => pm.Medicament)
                .Where(p => p.IdPrescription == id).ToListAsync();

            if (prescriptionFound == null) {
                return null;
            }

            var prescriptionResponse = prescriptionFound
                .Select(p => new PrescriptionDTO()
                {
                    FirstNamePatient = p.Patient.FirstName,
                    LastNamePatient = p.Patient.LastName,
                    BirthdatePatient = p.Patient.Birthdate,
                    FirstNameDoctor = p.Doctor.FirstName,
                    LastNameDoctor = p.Doctor.LastName,
                    DoctorEmail = p.Doctor.Email,
                    Medicaments = p.Prescribed_Medications.Select(pm => new MedicamentDTO()
                    {
                        Name = pm.Medicament.Name,
                        Description = pm.Medicament.Description,
                        Type = pm.Medicament.Type
                    }).ToList()
                });

            return prescriptionResponse;
        }
    }
}
