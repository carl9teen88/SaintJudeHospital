using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Seed
{
     internal class Symtoms
     {
        public static void Data (ModelBuilder builder)
        {
            builder.Entity<Symtom>().HasData(
                new Symtom { Id = 1, Name = "Bleeding" },
                new Symtom { Id = 2, Name = "Bruise" },
                new Symtom { Id = 3, Name = "Cough" },
                new Symtom { Id = 4, Name = "Bites" },
                new Symtom { Id = 5, Name = "Fever" },
                new Symtom { Id = 6, Name = "Cold" },
                new Symtom { Id = 7, Name = "Difficulty in swallowing" },
                new Symtom { Id = 8, Name = "Ear discharge" },
                new Symtom { Id = 9, Name = "Ear ache/pain" },
                new Symtom { Id = 10, Name = "Constipation" },
                new Symtom { Id = 11, Name = "Diarrhea" },
                new Symtom { Id = 12, Name = "Hair fall" },
                new Symtom { Id = 13, Name = "Abdominal pain" },
                new Symtom { Id = 14, Name = "Deformity" },
                new Symtom { Id = 15, Name = "Headache" },
                new Symtom { Id = 16, Name = "Infected wounds" },
                new Symtom { Id = 17, Name = "Itchness" },
                new Symtom { Id = 18, Name = "Loss of consciousness" },
                new Symtom { Id = 19, Name = "Mass" },
                new Symtom { Id = 20, Name = "Joint pain" },
                new Symtom { Id = 21, Name = "Muscle pain" },
                new Symtom { Id = 22, Name = "Skin lesions" },
                new Symtom { Id = 23, Name = "Trauma" },
                new Symtom { Id = 24, Name = "Pain urination" },
                new Symtom { Id = 25, Name = "Rushes" },
                new Symtom { Id = 26, Name = "Less appetite" },
                new Symtom { Id = 27, Name = "LBM" },
                new Symtom { Id = 28, Name = "Vomiting" },
                new Symtom { Id = 29, Name = "Dysuria" },
                new Symtom { Id = 30, Name = "Rashes" },
                new Symtom { Id = 31, Name = "Dysphagia" },
                new Symtom { Id = 32, Name = "Vaginal Discharge" },
                new Symtom { Id = 33, Name = "Urticarial rash" },
                new Symtom { Id = 34, Name = "Eye discharge" },
                new Symtom { Id = 35, Name = "Chest gurgling" },
                new Symtom { Id = 36, Name = "Epistaxis" },
                new Symtom { Id = 37, Name = "Pustules" },
                new Symtom { Id = 38, Name = "Nasal congestion" });
        }
    }
}
