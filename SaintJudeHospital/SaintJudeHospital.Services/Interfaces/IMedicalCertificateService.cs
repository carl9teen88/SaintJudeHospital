using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IMedicalCertificateService : IService
    {
        IQueryable<MedicalCertificate> GetAll();
        IQueryable<MedicalCertificate> GetByPatient(int id);
        IQueryable<MedicalCertificate> GetByDateRange(DateTime dateFrom, DateTime dateTo);
        MedicalCertificate Get(int id);
    }
}
