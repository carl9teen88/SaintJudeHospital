using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface ICheckupService : IService
    {
        IQueryable<Checkup> GetAll();
        IQueryable<Checkup> GetByName(string name);
        Checkup Get(int id);        
    }
}
