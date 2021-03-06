﻿using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IImmunizationService : IService
    {
        IQueryable<Immunize> GetAll(int page, int rrp);
        Immunize GetById(int id);
    }
}
