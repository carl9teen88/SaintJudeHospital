using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Services.Impl
{
    public class RoleService : IRoleService
    {
        private readonly AppDbContext _context;

       public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public Role Get(int id)
        {
            return _context.Roles.Find(id);
        }

        public IQueryable<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetByName(string name)
        {
            return _context.Roles.FirstOrDefault(r => r.Name == name);
        }
    }
}
