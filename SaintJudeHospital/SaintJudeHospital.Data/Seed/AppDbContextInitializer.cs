using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Data.Seed
{
    public class AppDbContextInitializer
    {
        private static ModelBuilder _builder;

        public static void Load(ModelBuilder builder)
        {
            _builder = builder;

            UsersRole();
            Users();
            Immunizes.Data(builder);
            Symtoms.Data(builder);
            Brands.Data(builder);
            Inscriptions.Data(builder);
            Generics.Data(builder);
            Medicines.Data(builder);
        }

        private static void UsersRole()
        {
            _builder.Entity<Role>().HasData(
                new Role { RoleId = 1, Name = "Administrator" },
                new Role { RoleId = 2, Name = "StandardUser"});
        }

        private static void Users()
        {
            _builder.Entity<User>().HasData(
                new User { FirstName = "Carl", LastName = "Tanilon", Password = "1234", RoleId = 1, Username = "carl" , UserId = 1});
        }   
    }
}
