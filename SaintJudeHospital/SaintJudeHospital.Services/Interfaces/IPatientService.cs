using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IPatientService : IService
    {
        IQueryable<Patient> GetAll();
        IQueryable<Patient> GetByName(string lastname);
        Patient Get(int id);
    }
}
