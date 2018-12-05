using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IVaccineTypeService : IService
    {
        IQueryable<VaccineType> GetAll();

        VaccineType Get(int id);
        VaccineType GetByName(string name);
    }
}
