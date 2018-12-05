using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Seed
{
    internal class Immunizes
    {
        public static void Data(ModelBuilder builder)
        {
            builder.Entity<Immunize>().HasData(
                new Immunize { Id = 1, Name = "HEXA", Amount = 3000 },
                new Immunize { Id = 2, Name = "PCV 10", Amount = 3200 },
                new Immunize { Id = 3, Name = "MEASLES", Amount = 750 },
                new Immunize { Id = 4, Name = "HIB", Amount = 1300 },
                new Immunize { Id = 5, Name = "MENINGO", Amount = 4000 },
                new Immunize { Id = 6, Name = "TYPHOID", Amount = 1300 },
                new Immunize { Id = 7, Name = "HEP A", Amount = 1800 },
                new Immunize { Id = 8, Name = "HEP B", Amount = 700 },
                new Immunize { Id = 9, Name = "TETRAXIM", Amount = 1600 },
                new Immunize { Id = 10, Name = "MMR", Amount = 1200 },
                new Immunize { Id = 11, Name = "CHICKEN POX", Amount = 2200 },
                new Immunize { Id = 12, Name = "PENTA", Amount = 2500 },
                new Immunize { Id = 13, Name = "BCG-1", Amount = 900 },
                new Immunize { Id = 14, Name = "MMR-V", Amount = 3000 },
                new Immunize { Id = 15, Name = "PNEUMO-23", Amount = 1700 },
                new Immunize { Id = 16, Name = "RABIES", Amount = 1700 },
                new Immunize { Id = 17, Name = "ROTARIX", Amount = 3000 },
                new Immunize { Id = 18, Name = "ROTATEQ", Amount = 2200 },
                new Immunize { Id = 19, Name = "FLU", Amount = 1000 },
                new Immunize { Id = 20, Name = "PCV", Amount = 4000 },
                new Immunize { Id = 21, Name = "BCG-2", Amount = 0 });
        }
    }
}
