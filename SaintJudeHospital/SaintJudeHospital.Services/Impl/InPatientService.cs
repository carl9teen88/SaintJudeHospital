using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class InPatientService : IInPatientService
    {
        private readonly AppDbContext _context;

        public InPatientService(AppDbContext context)
        {
            _context = context;
        }

        public InPatient Get(int id)
        {
            return _context.InPatients.Find(id);
        }

        public IQueryable<InPatient> GetAll()
        {
            return _context.InPatients;
        }

        public IQueryable<InPatient> GetByDateRange(DateTime dateFrom, DateTime dateTo)
        {
            return _context.InPatients.Where(i => i.CreateDate >= dateFrom && i.CreateDate <= dateTo);
        }

        public IQueryable<InPatient> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
