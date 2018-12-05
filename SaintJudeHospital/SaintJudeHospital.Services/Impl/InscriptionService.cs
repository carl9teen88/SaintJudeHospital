using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class InscriptionService : IInscriptionService
    {
        private readonly AppDbContext _context;

        public InscriptionService(AppDbContext context)
        {
            _context = context;
        }

        public Inscription Get(int id)
        {
            return _context.Inscriptions.Find(id);
        }

        public IQueryable<Inscription> GetAll()
        {
            return _context.Inscriptions;
        }

        public IQueryable<Inscription> GetByName(string name)
        {
            return _context.Inscriptions.Where(i => i.Name == name);
        }
    }
}
