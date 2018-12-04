using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IGenericService : IService
    {
        IQueryable<Generic> GetAll();
        Generic Get(int id);
        Generic GetByName(string name);
    }
}
