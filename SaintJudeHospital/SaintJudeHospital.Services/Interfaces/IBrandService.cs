using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IBrandService : IService
    {
        IQueryable<Brand> GetAll();
        Brand Get(int id);
        Brand GetByName(string name);
    }
}
