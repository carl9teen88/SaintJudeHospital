using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class MedicalCertificateService : IMedicalCertificateService
    {
        private readonly AppDbContext _context;

        public MedicalCertificateService(AppDbContext context)
        {
            _context = context;
        }

        public MedicalCertificate Get(int id)
        {
            return _context.MedicalCertificates.Find(id);
        }

        public IQueryable<MedicalCertificate> GetAll()
        {
            return _context.MedicalCertificates;
        }

        public IQueryable<MedicalCertificate> GetByDateRange(DateTime dateFrom, DateTime dateTo)
        {
            return _context.MedicalCertificates.Where(m => m.CreatedDate >= dateFrom && m.CreatedDate <=dateTo);
        }

        public IQueryable<MedicalCertificate> GetByPatient(int patientId)
        {
            return _context.MedicalCertificates.Where(m => m.PatientId == patientId);
        }
    }
}
