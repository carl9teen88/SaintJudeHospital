using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class MedicineService : IMedicineService
    {
        private readonly AppDbContext _context;

        public MedicineService(AppDbContext context)
        {
            _context = context;
        }

        public Medicine Get(int id)
        {
            return _context.Medicines.Find(id);
        }

        public IQueryable<Medicine> GetAll()
        {
            return _context.Medicines;
        }
    }
}
