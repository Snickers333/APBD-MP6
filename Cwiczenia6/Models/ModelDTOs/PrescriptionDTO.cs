namespace Cwiczenia6.Models
{
    public class PrescriptionDTO
    {
        public string FirstNamePatient { get; set; } = null!;
        public string LastNamePatient { get; set; } = null!;
        public string FirstNameDoctor { get; set; } = null!;
        public string LastNameDoctor { get; set; } = null!;
        public string DoctorEmail { get; set; } = null!;
        public DateTime BirthdatePatient { get; set; }
        public List<MedicamentDTO> Medicaments { get; set; } = new List<MedicamentDTO>();
    }
}
