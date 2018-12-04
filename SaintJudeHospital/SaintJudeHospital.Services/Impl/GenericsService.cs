using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Linq;

namespace SaintJudeHospital.Services.Impl
{
    public class GenericsService : IGenericService
    {
        private readonly AppDbContext _context;

        public GenericsService(AppDbContext context)
        {
            _context = context;
        }

        public Generic Get(int id)
        {
            return _context.Generics.Find(id);
        }

        public IQueryable<Generic> GetAll()
        {
            return _context.Generics
                .OrderBy(i => i.Name);
        }

        public Generic GetByName(string name)
        {
            return _context.Generics.FirstOrDefault(g => g.Name == name);
        }
    }
}
