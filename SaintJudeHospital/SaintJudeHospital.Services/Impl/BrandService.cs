using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _context;

        public BrandService(AppDbContext context)
        {
            _context = context;
        }

        public Brand Get(int id)
        {
            return _context.Brands.Find(id);
        }

        public IQueryable<Brand> GetAll()
        {
            return _context.Brands;
        }

        public Brand GetByName(string name)
        {
            return _context.Brands.FirstOrDefault(b => b.Name == name);
        }
    }
}
