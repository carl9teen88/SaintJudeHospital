using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class BillService : IBillService
    {
        private readonly AppDbContext _context;

        public BillService(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Bill> GetAll()
        {
            return _context.Bills;
        }

        public IQueryable<Bill> GetByCheckup(int checkupId)
        {
            return _context.Bills.Where(b => b.CheckupId == checkupId);
        }

        public IQueryable<Bill> GetByDateRange(DateTime dateFrom, DateTime dateTo)
        {
            return _context.Bills.Where(b => b.CreatedDate >= dateFrom && b.CreatedDate <= dateTo);
        }

        public IQueryable<Bill> GetByPatient(int patientId)
        {
            return _context.Bills.Where(b => b.PatientId == patientId);
        }
    }
}
