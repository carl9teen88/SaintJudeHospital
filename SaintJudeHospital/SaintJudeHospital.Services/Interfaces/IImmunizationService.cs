using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IImmunizationService
    {
        IQueryable<Immunize> GetImmunizes(int page, int rrp);
        Immunize GetImmunizeById(int id);
    }
}
