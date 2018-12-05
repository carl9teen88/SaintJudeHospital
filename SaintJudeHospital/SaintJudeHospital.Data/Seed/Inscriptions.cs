using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Seed
{
    internal class Inscriptions
    {
        public static void Data(ModelBuilder builder)
        {
            builder.Entity<Inscription>().HasData(
                new Inscription { Id = 1, Name = "Ai Lotion" },
                new Inscription { Id = 2, Name = "Amp" },
                new Inscription { Id = 3, Name = "Campsuele" },
                new Inscription { Id = 4, Name = "Cream" },
                new Inscription { Id = 5, Name = "Drops" },
                new Inscription { Id = 6, Name = "Eyedrops" },
                new Inscription { Id = 7, Name = "Granules" },
                new Inscription { Id = 8, Name = "Lotion" },
                new Inscription { Id = 9, Name = "MDI" },
                new Inscription { Id = 10, Name = "Nail Lacquer" },
                new Inscription { Id = 11, Name = "Nasal Drops" },
                new Inscription { Id = 12, Name = "Nebule" },
                new Inscription { Id = 13, Name = "Ointment" },
                new Inscription { Id = 14, Name = "Oral Gel" },
                new Inscription { Id = 15, Name = "Oral Solution" },
                new Inscription { Id = 16, Name = "Pediatric Capsule" },
                new Inscription { Id = 17, Name = "Pediatric Suppository" },
                new Inscription { Id = 18, Name = "Sachet" },
                new Inscription { Id = 19, Name = "Skin Cleanser" },
                new Inscription { Id = 20, Name = "Solution" },
                new Inscription { Id = 21, Name = "Suppository" },
                new Inscription { Id = 22, Name = "Suspension" },
                new Inscription { Id = 23, Name = "Syrup" },
                new Inscription { Id = 24, Name = "Tablet" },
                new Inscription { Id = 25, Name = "Tube" },
                new Inscription { Id = 26, Name = "Bottle" },
                new Inscription { Id = 27, Name = "Nasal Spray" },
                new Inscription { Id = 28, Name = "Can" });
        }
    }
}
