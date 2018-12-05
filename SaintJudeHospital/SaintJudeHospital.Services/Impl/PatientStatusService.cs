using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class PatientStatusService : IPatientStatusService
    {
        private readonly AppDbContext _context;

        public PatientStatusService(AppDbContext context)
        {
            _context = context;
        }

        public PatientStatus Get(int id)
        {
            return _context.PatientStatuses.Find(id);
        }

        public IQueryable<PatientStatus> GetAll()
        {
            return _context.PatientStatuses;
        }

        public PatientStatus GetByName(string name)
        {
            return _context.PatientStatuses.FirstOrDefault(p => p.Name == name);
        }
    }
}
