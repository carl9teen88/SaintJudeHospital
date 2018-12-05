using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IPatientStatusService : IService
    {
        IQueryable<PatientStatus> GetAll();
        PatientStatus Get(int id);
        PatientStatus GetByName(string name);
    }
}
