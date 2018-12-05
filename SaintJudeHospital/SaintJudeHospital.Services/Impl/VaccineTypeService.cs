using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class VaccineTypeService : IVaccineTypeService
    {
        private readonly AppDbContext _context;

        public VaccineTypeService(AppDbContext context)
        {
            _context = context;
        }

        public VaccineType Get(int id)
        {
            return _context.VaccineTypes.Find(id);
        }

        public IQueryable<VaccineType> GetAll()
        {
            return _context.VaccineTypes;
        }

        public VaccineType GetByName(string name)
        {
            return _context.VaccineTypes.FirstOrDefault(v => v.Name == name);
        }
    }
}
