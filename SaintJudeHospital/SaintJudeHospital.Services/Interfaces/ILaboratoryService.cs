using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface ILaboratoryService : IService
    {
        IQueryable<Laboratory> GetAll();
        Laboratory Get(int id);
        Laboratory GetByName(string name);
    }
}
