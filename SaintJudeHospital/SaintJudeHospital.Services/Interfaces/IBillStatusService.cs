using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IBillStatusService : IService
    {
        IQueryable<BillStatus> GetAll();
        BillStatus Get(int id);
        BillStatus GetByName(string name);
    }
}
