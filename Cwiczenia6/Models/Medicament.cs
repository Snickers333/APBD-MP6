using System.Collections.ObjectModel;

namespace Cwiczenia6.Models
{
    public class Medicament
    {
        public int IdMedicament { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Type { get; set; } = null!;
        public virtual ICollection<Prescription_Medicament> Prescribed_Medications { get; set; } = new List<Prescription_Medicament>();
    }
}
