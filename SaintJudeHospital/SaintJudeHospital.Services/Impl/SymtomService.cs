using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class SymtomService : ISymtomService
    {
        private readonly AppDbContext _context;

        public SymtomService(AppDbContext context)
        {
            _context = context;
        }

        public Symtom Get(int id)
        {
            return _context.Symtoms.Find(id);
        }

        public IQueryable<Symtom> GetAll()
        {
            return _context.Symtoms;
        }

        public Symtom GetByName(string name)
        {
            return _context.Symtoms.FirstOrDefault(s => s.Name == name);
        }
    }
}
