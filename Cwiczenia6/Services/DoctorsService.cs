using Cwiczenia6.Data;
using Cwiczenia6.Models;

namespace Cwiczenia6.Services
{
    public interface IDoctorsService
    {
        Task putDoctor(int id, DoctorPUT doctorPUT);
        Task addDoctor(DoctorPOST doctorPOST);
        public Task<IEnumerable<DoctorGET>> getDoctorsData();
        Task deleteDoctor(int id);
    }
    public class DoctorsService : IDoctorsService
    {
        private readonly DataContext _context;
        public DoctorsService(DataContext context)
        {
            _context = context;
        }

        public async Task addDoctor(DoctorPOST doctorPOST)
        {
            var doctor = new Doctor
            {
                FirstName = doctorPOST.FirstName,
                LastName = doctorPOST.LastName,
                Email = doctorPOST.Email
            };
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public async Task deleteDoctor(int id)
        {
            var doctor = _context.Doctors.Find(id);
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<DoctorGET>> getDoctorsData()
        {
            var output = _context.Doctors.Select(x => new DoctorGET
            {
                IdDoctor = x.IdDoctor,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email
            }) ;
            return output;
        }

        public async Task putDoctor(int id, DoctorPUT doctorPUT)
        {
            var doctor = _context.Doctors.FirstOrDefault(e => e.IdDoctor == id);
            doctor.FirstName = doctorPUT.FirstName;
            doctor.LastName = doctorPUT.LastName;
            doctor.Email = doctorPUT.Email;
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }
    }
}
