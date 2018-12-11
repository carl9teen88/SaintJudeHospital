using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Data.Indentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Data.Seed
{
    public class AppDbContextInitializer
    {
        private static ModelBuilder _builder;

        public static void LoadDefaultData(ModelBuilder builder)
        {
            _builder = builder;

            Immunizes.Data(builder);
            Symtoms.Data(builder);
            Brands.Data(builder);
            Inscriptions.Data(builder);
            Generics.Data(builder);
            Medicines.Data(builder);
        }

        public static void LoadApplicationUser(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();

            var manager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            context.Database.EnsureCreated();

            if(!context.Users.Any())
            {
                var user = new ApplicationUser
                {
                    Email = "dharl072810@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "dharl",
                    FirstName = "Carl",
                    LastName = "Tanilon",
                    CreatedDate = DateTime.Now,
                    IsDelete = false,
                    PhoneNumber = "09177080814",
                    PhoneNumberConfirmed = true,
                    EmailConfirmed = true
                };

                var result = manager.CreateAsync(user, "Dharl_143");

                context.SaveChanges();
            }
        }
    }
}
