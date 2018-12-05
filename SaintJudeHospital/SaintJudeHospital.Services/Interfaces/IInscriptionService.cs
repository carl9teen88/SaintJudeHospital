using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IInscriptionService : IService
    {
        IQueryable<Inscription> GetAll();
        IQueryable<Inscription> GetByName(string name);
        Inscription Get(int id);
    }
}
