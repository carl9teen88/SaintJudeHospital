using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IRoleService : IService
    {
        IQueryable<Role> GetAll();
        Role Get(int id);
        Role GetByName(string name);
    }
}
