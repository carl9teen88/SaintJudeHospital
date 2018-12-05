using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class CheckupService : ICheckupService
    {
        private readonly AppDbContext _context;

        public CheckupService(AppDbContext context)
        {
            _context = context;
        }

        public Checkup Get(int id)
        {
            return _context.Checkups.Find(id);
        }

        public IQueryable<Checkup> GetAll()
        {
            return _context.Checkups;
        }

        public IQueryable<Checkup> GetByName(string name)
        {
            return _context.Checkups.Where(c => c.Name == name);
        }
    }
}
