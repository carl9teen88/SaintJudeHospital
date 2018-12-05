﻿using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Seed
{
    internal class Generics
    {
        public static void Data(ModelBuilder builder)
        {
            builder.Entity<Generic>().HasData(
                new Generic { Id = 1, Name = "Acetylcysteine" },
                new Generic { Id = 2, Name = "Acyclovir" },
                new Generic { Id = 3, Name = "Aluminum Magnesium Hydroxide" },
                new Generic { Id = 4, Name = "Ambroxol" },
                new Generic { Id = 5, Name = "Amorolfine" },
                new Generic { Id = 6, Name = "Amoxicillin" },
                new Generic { Id = 7, Name = "Ampicillin IV" },
                new Generic { Id = 8, Name = "Azithromycin" },
                new Generic { Id = 9, Name = "Bacillus Clausii" },
                new Generic { Id = 10, Name = "Bambuterol" },
                new Generic { Id = 11, Name = "Betaine Glucuronate Plus" },
                new Generic { Id = 12, Name = "Brompheniramine Maleate + Phenylephrine" },
                new Generic { Id = 13, Name = "Brompheniramine Maleate + Phenylpropanolamine" },
                new Generic { Id = 14, Name = "Broncho Vaxom" },
                new Generic { Id = 15, Name = "Calmoseptine" },
                new Generic { Id = 16, Name = "Carbocisteine" },
                new Generic { Id = 17, Name = "Cefaclor" },
                new Generic { Id = 18, Name = "Cefaclor + Guaifenesin" },
                new Generic { Id = 19, Name = "Cefalexin" },
                new Generic { Id = 20, Name = "Cefixime" },
                new Generic { Id = 21, Name = "Cefuroxime" },
                new Generic { Id = 22, Name = "Cetirizine" },
                new Generic { Id = 23, Name = "Chloramphenicol" },
                new Generic { Id = 24, Name = "Clarithromycin" },
                new Generic { Id = 25, Name = "Clindamycin" },
                new Generic { Id = 26, Name = "Clotrimazole + Betamethasone" },
                new Generic { Id = 27, Name = "Cloxacillin" },
                new Generic { Id = 28, Name = "Co Amoxiclav" },
                new Generic { Id = 29, Name = "Cotrimoxazole" },
                new Generic { Id = 30, Name = "Dg Milk" },
                new Generic { Id = 31, Name = "Dibencozide" },
                new Generic { Id = 32, Name = "Domperidone" },
                new Generic { Id = 33, Name = "Doxofylline" },
                new Generic { Id = 34, Name = "Eperisone HCI" },
                new Generic { Id = 35, Name = "Erythromycin" },
                new Generic { Id = 36, Name = "Ferrous Gluconate" },
                new Generic { Id = 37, Name = "Fluocloxacillin" },
                new Generic { Id = 38, Name = "Fluticasone Furoate" },
                new Generic { Id = 39, Name = "Fucidic Acid" },
                new Generic { Id = 40, Name = "Fucidic Acid + Hydrocortisone" },
                new Generic { Id = 41, Name = "Furazolidone" },
                new Generic { Id = 42, Name = "Fusidate Sodium" },
                new Generic { Id = 43, Name = "Gentamicin IV" },
                new Generic { Id = 44, Name = "Gentamycin" },
                new Generic { Id = 45, Name = "Glycerin" },
                new Generic { Id = 46, Name = "Hydroxyzine diHCI" },
                new Generic { Id = 47, Name = "Ibuprofen" },
                new Generic { Id = 48, Name = "Inosiplex" },
                new Generic { Id = 49, Name = "Lactulose" },
                new Generic { Id = 50, Name = "Levocetirizine Diltci" },
                new Generic { Id = 51, Name = "Mebendazole" },
                new Generic { Id = 52, Name = "Mefenamic Acid" },
                new Generic { Id = 53, Name = "Metronidazole" },
                new Generic { Id = 54, Name = "Miconazole" },
                new Generic { Id = 55, Name = "Mometasone Furoate" },
                new Generic { Id = 56, Name = "Montelukast" },
                new Generic { Id = 57, Name = "Multivitamins" },
                new Generic { Id = 58, Name = "Mupirocin" },
                new Generic { Id = 59, Name = "Naproxen Sodium" },
                new Generic { Id = 60, Name = "Nifuroxazide" },
                new Generic { Id = 61, Name = "Nystatin" },
                new Generic { Id = 62, Name = "Omeprazole" },
                new Generic { Id = 63, Name = "Oral Rehydration Solution" },
                new Generic { Id = 64, Name = "Paracetamol" },
                new Generic { Id = 65, Name = "Paracetamol + Phenylpropanolamine" },
                new Generic { Id = 66, Name = "Phenoxymethylpenicillin K" },
                new Generic { Id = 67, Name = "Phenylephrine Hcl + Chlorpheniramine Maleate" },
                new Generic { Id = 68, Name = "Phenylpropanolamine" },
                new Generic { Id = 69, Name = "Phospholipids" },
                new Generic { Id = 70, Name = "Physiogel" },
                new Generic { Id = 71, Name = "Prednisolone" },
                new Generic { Id = 72, Name = "Prednisone" },
                new Generic { Id = 73, Name = "Procaterol" },
                new Generic { Id = 74, Name = "Pyrantel Pamoate" },
                new Generic { Id = 75, Name = "Salbutamol" },
                new Generic { Id = 76, Name = "Salbutamol + Guaifenesin" },
                new Generic { Id = 77, Name = "Salbutamol + Ipratropium Bromide" },
                new Generic { Id = 78, Name = "Salmeterol + Fluticasone Propionate" },
                new Generic { Id = 79, Name = "Simethicone" },
                new Generic { Id = 80, Name = "Sodium Chloride" },
                new Generic { Id = 81, Name = "Terbutaline" },
                new Generic { Id = 82, Name = "Theophylline" },
                new Generic { Id = 83, Name = "Zinc Sulfate" });
        }
    }
}
