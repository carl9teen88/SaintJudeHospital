using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IVaccineService : IService
    {
        IQueryable<Vaccine> GetAll();
        IQueryable<Vaccine> GetByName(string name);
        Vaccine Get(int id);
    }
}
