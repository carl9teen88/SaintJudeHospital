using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class PatientService : IPatientService
    {
        private readonly AppDbContext _context;

        public PatientService(AppDbContext context) 
        {
            _context = context;
        }

        public Patient Get(int id)
        {
            return _context.Patients.Find(id);
        }

        public IQueryable<Patient> GetAll()
        {
            return _context.Patients;
        }

        public IQueryable<Patient> GetByName(string lastname)
        {
            return _context.Patients.Where(p => p.LastName == lastname);
        }
    }
}
