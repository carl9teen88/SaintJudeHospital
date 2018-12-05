using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class LaboratoryService : ILaboratoryService
    {
        private readonly AppDbContext _context;

        public LaboratoryService(AppDbContext context)
        {
            _context = context;
        }

        public Laboratory Get(int id)
        {
            return _context.Laboratories.Find(id);
        }

        public IQueryable<Laboratory> GetAll()
        {
            return _context.Laboratories;
        }

        public Laboratory GetByName(string name)
        {
            return _context.Laboratories.FirstOrDefault(l => l.Name == name);
        }
    }
}
