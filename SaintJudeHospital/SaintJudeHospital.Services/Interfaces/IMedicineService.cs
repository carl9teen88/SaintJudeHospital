using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IMedicineService : IService
    {
        IQueryable<Medicine> GetAll();
        Medicine Get(int id);
    }
}
