using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class VaccineService : IVaccineService
    {
        private readonly AppDbContext _context;

        public VaccineService(AppDbContext context)
        {
            _context = context;
        }

        public Vaccine Get(int id)
        {
            return _context.Vaccines.Find(id);
        }

        public IQueryable<Vaccine> GetAll()
        {
            return _context.Vaccines;
        }

        public IQueryable<Vaccine> GetByName(string name)
        {
            return _context.Vaccines.Where(v => v.Name == name);
        }
    }
}
