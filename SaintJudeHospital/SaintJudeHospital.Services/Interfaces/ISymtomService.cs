using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface ISymtomService : IService
    {
        IQueryable<Symtom> GetAll();
        Symtom Get(int id);
        Symtom GetByName(string name);
    }
}
