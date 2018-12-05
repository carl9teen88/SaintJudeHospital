using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IInPatientService : IService
    {
        IQueryable<InPatient> GetAll();
        IQueryable<InPatient> GetByName(string name);
        IQueryable<InPatient> GetByDateRange(DateTime dateFrom, DateTime dateTo);
        InPatient Get(int id);
    }
}
