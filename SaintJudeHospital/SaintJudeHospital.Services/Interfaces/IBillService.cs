using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IBillService : IService
    {
        IQueryable<Bill> GetAll();
        IQueryable<Bill> GetByDateRange(DateTime dateFrom, DateTime dateTo);
        IQueryable<Bill> GetByPatient(int patientId);
        IQueryable<Bill> GetByCheckup(int checkupId);
    }
}
