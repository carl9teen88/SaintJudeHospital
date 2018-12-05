using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Interfaces
{
    public interface IUserService : IService
    {
        IQueryable<User> GetAll();
        User Get(int id);
        User GetByUsername(string username);
    }
}
