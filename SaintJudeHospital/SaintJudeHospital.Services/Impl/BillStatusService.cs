using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class BillStatusService : IBillStatusService
    {
        private readonly AppDbContext _context;

        public BillStatusService(AppDbContext context)
        {
            _context = context;
        }

        public BillStatus Get(int id)
        {
            return _context.BillStatuses.Find(id);
        }

        public IQueryable<BillStatus> GetAll()
        {
            return _context.BillStatuses;
        }

        public BillStatus GetByName(string name)
        {
            return _context.BillStatuses.FirstOrDefault(b => b.Name == name);
        }
    }
}
