using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Seed
{
    internal class Laboratories
    {
        public static void Data(ModelBuilder builder)
        {
            builder.Entity<Laboratory>().HasData(
                new Laboratory { Id = 1, Name = "75 gms.OGTT" },
                new Laboratory { Id = 2, Name = "Acid Fast Bacili Staining(AFB)" },
                new Laboratory { Id = 3, Name = "24 Urine Cortisol" },
                new Laboratory { Id = 4, Name = "50 gms.OGTT" },
                new Laboratory { Id = 5, Name = "* Alpha - fetoprotein(AFP)" },
                new Laboratory { Id = 6, Name = "* Amylase(Urine)" },
                new Laboratory { Id = 7, Name = "* Amylase(Blood)" },
                new Laboratory { Id = 8, Name = "2 HPPBS" },
                new Laboratory
                {
                    Id = 9,
                    Name = "* Acid Phosphatase(ACP)"
                },
                new Laboratory
                {
                    Id = 10,
                    Name = "Acid Phosphatase(Prostatic ACP)"
                },
                new Laboratory
                {
                    Id = 11,
                    Name = "100 gms.OGTT"
                },
                new Laboratory
                {
                    Id = 12,
                    Name = "Albumin / Globulin(Alb / Glob)"
                },
                new Laboratory
                {
                    Id = 13,
                    Name = "* ANA(Screening and Panel)"
                },
                new Laboratory
                {
                    Id = 14,
                    Name = "* Anti - HAV lgM"
                },
                new Laboratory
                {
                    Id = 15,
                    Name = "Alkaline Phosphatase(ALP)"
                },
                new Laboratory
                {
                    Id = 16,
                    Name = "* Anti - HBc lgM"
                },
                new Laboratory
                {
                    Id = 17,
                    Name = "* Anti - Hav Total"
                },
                new Laboratory
                {
                    Id = 18,
                    Name = "* Anti - HBe"
                },
                new Laboratory
                {
                    Id = 19,
                    Name = "* Anti - HBc Total"
                },
                new Laboratory
                {
                    Id = 20,
                    Name = "* Anti - streptolysin O Titer(ASO Titer)"
                },
                new Laboratory
                {
                    Id = 21,
                    Name = "* Anti - HCV(Screening)"
                },
                new Laboratory
                {
                    Id = 22,
                    Name = "* Anti - H.Pylori"
                },
                new Laboratory
                {
                    Id = 23,
                    Name = "* Anti - HCV EIA"
                },
                new Laboratory
                {
                    Id = 24,
                    Name = "* Anti - HBs(Semi - QUanti)"
                },
                new Laboratory
                {
                    Id = 25,
                    Name = "* Anti - HBs Titer"
                },
                new Laboratory
                {
                    Id = 26,
                    Name = "Beta - HCG / Dilution(Urine)"
                },
                new Laboratory
                {
                    Id = 27,
                    Name = "* Beta - HCG(Blood)"
                },
                new Laboratory
                {
                    Id = 28,
                    Name = "Biliribin - Direct / Indirect(DB / IB)"
                },
                new Laboratory
                {
                    Id = 29,
                    Name = "* Biopsy(Small)"
                },
                new Laboratory
                {
                    Id = 30,
                    Name = "Blood Urea Nitrogen(BUN)"
                },
                new Laboratory
                {
                    Id = 31,
                    Name = "Blood Indices"
                },
                new Laboratory
                {
                    Id = 32,
                    Name = "Blood Typing(BT)"
                },
                new Laboratory
                {
                    Id = 33,
                    Name = "* Biopsy(Lagre)"
                },
                new Laboratory
                {
                    Id = 34,
                    Name = "Bilirubin - Total(TB)"
                },
                new Laboratory
                {
                    Id = 35,
                    Name = "Blood Uric Acid(BUA)"
                },
                new Laboratory
                {
                    Id = 36,
                    Name = "* C3 700 - W / I"
                },
                new Laboratory
                {
                    Id = 37,
                    Name = "* Carcino - embryonic Ag(CEA)"
                },
                new Laboratory
                {
                    Id = 38,
                    Name = "Calcium(Urine Ca++)"
                },
                new Laboratory
                {
                    Id = 39,
                    Name = "* C4 750 - W / I"
                },
                new Laboratory
                {
                    Id = 40,
                    Name = "* CA 19.9"
                },
                new Laboratory
                {
                    Id = 41,
                    Name = "* CA 15.3"
                },
                new Laboratory
                {
                    Id = 42,
                    Name = "* CA 125"
                },
                new Laboratory
                {
                    Id = 43,
                    Name = "* C - Reactive Protein(CRP)"
                },
                new Laboratory
                {
                    Id = 44,
                    Name = "Calcium(Blood Ca++)"
                },
                new Laboratory
                {
                    Id = 45,
                    Name = "* Cortisol"
                },
                new Laboratory
                {
                    Id = 46,
                    Name = "* Cholinesterase - Serum"
                },
                new Laboratory
                {
                    Id = 47,
                    Name = "Complete Blood Count(CBC)"
                },
                new Laboratory
                {
                    Id = 48,
                    Name = "* Creatine Kinase(CK - MB)"
                },
                new Laboratory
                {
                    Id = 49,
                    Name = "Creatinine Total(Urine)"
                },
                new Laboratory
                {
                    Id = 50,
                    Name = "Cerebrospinal Fluid Routine(CSF)"
                },
                new Laboratory
                {
                    Id = 51,
                    Name = "Chloride(CI -)"
                },
                new Laboratory
                {
                    Id = 52,
                    Name = "Chlamydia w / Check - up"
                },
                new Laboratory
                {
                    Id = 53,
                    Name = "Cholesterol - Total"
                },
                new Laboratory
                {
                    Id = 54,
                    Name = "Cholesterol(HDL / VLD / LDL)"
                },
                new Laboratory
                {
                    Id = 55,
                    Name = "Cholinesterase - RBC"
                },
                new Laboratory
                {
                    Id = 56,
                    Name = "Creatinine(Blood)"
                },
                new Laboratory
                {
                    Id = 57,
                    Name = "Dengue NS1 Ag"
                },
                new Laboratory
                {
                    Id = 58,
                    Name = "* DsDNA"
                },
                new Laboratory
                {
                    Id = 59,
                    Name = "Erythrocyte Sedimentation Rate(ESR)"
                },
                new Laboratory
                {
                    Id = 60,
                    Name = "* Estradiol"
                },
                new Laboratory
                {
                    Id = 61,
                    Name = "Free Thyroxine(FT4)"
                },
                new Laboratory
                {
                    Id = 62,
                    Name = "* Free Triiodothyronine(FT3)"
                },
                new Laboratory
                {
                    Id = 63,
                    Name = "Gamma - GT(GGT)"
                },
                new Laboratory
                {
                    Id = 64,
                    Name = "* Ferritin"
                },
                new Laboratory
                {
                    Id = 65,
                    Name = "Clotting Time - Bleeding Time(CT - BT)"
                },
                new Laboratory
                {
                    Id = 66,
                    Name = "Fasting Blood Sugar(FBS)"
                },
                new Laboratory
                {
                    Id = 67,
                    Name = "Eosinophils"
                },
                new Laboratory
                {
                    Id = 68,
                    Name = "Hepatitis B Profile"
                },
                new Laboratory
                {
                    Id = 69,
                    Name = "Ketones"
                },
                new Laboratory
                {
                    Id = 70,
                    Name = "KOH"
                },
                new Laboratory
                {
                    Id = 71,
                    Name = "Hemoglucotest(HGT)"
                },
                new Laboratory
                {
                    Id = 72,
                    Name = "Hematocrit(Hct)"
                },
                new Laboratory
                {
                    Id = 73,
                    Name = "Gonorrhea w / Check - up"
                },
                new Laboratory
                {
                    Id = 74,
                    Name = "* Lactate Dehydrogenase(LDH)"
                },
                new Laboratory
                {
                    Id = 75,
                    Name = "L.E.Preparation"
                },
                new Laboratory
                {
                    Id = 76,
                    Name = "Lipid Profile"
                },
                new Laboratory
                {
                    Id = 77,
                    Name = "Liver Profile"
                },
                new Laboratory
                {
                    Id = 78,
                    Name = "* Luteinizing Hormone(LH)"
                },
                new Laboratory
                {
                    Id = 79,
                    Name = "* Magnesium(Mg + 2)"
                },
                new Laboratory
                {
                    Id = 80,
                    Name = "MCA"
                },
                new Laboratory
                {
                    Id = 81,
                    Name = "Micral Test"
                },
                new Laboratory
                {
                    Id = 82,
                    Name = "Glycosylated Hemoglobin(HbA1C)"
                },
                new Laboratory
                {
                    Id = 83,
                    Name = "Gram Staining(G / S)"
                },
                new Laboratory
                {
                    Id = 84,
                    Name = "Hemoglobin(Hgb)"
                },
                new Laboratory
                {
                    Id = 85,
                    Name = "HBsAg(Screening)"
                },
                new Laboratory
                {
                    Id = 86,
                    Name = "* HBsAg(EIA)"
                },
                new Laboratory
                {
                    Id = 87,
                    Name = "* HBeAg"
                },
                new Laboratory
                {
                    Id = 88,
                    Name = "Pregnancy Test(PT)"
                },
                new Laboratory
                {
                    Id = 89,
                    Name = "Potassium(Urine K +)"
                },
                new Laboratory
                {
                    Id = 90,
                    Name = "Peripheral Smear"
                },
                new Laboratory
                {
                    Id = 91,
                    Name = "Platelet Count(Plt.Ct.)"
                },
                new Laboratory
                {
                    Id = 92,
                    Name = "* Phosphorus(Inorg)"
                },
                new Laboratory
                {
                    Id = 93,
                    Name = "Newborn Screening(NBS)"
                },
                new Laboratory
                {
                    Id = 94,
                    Name = "Osmotic Fragility"
                },
                new Laboratory
                {
                    Id = 95,
                    Name = "Pap smear w / check up"
                },
                new Laboratory
                {
                    Id = 96,
                    Name = "* Parathyroid Hormone(PTH)"
                },
                new Laboratory
                {
                    Id = 97,
                    Name = "Pleural Routine"
                },
                new Laboratory
                {
                    Id = 98,
                    Name = "Potassium(Blood K +)"
                },
                new Laboratory
                {
                    Id = 99,
                    Name = "Occult Blood"
                },
                new Laboratory
                {
                    Id = 100,
                    Name = "Malarial Smear"
                },
                new Laboratory
                {
                    Id = 101,
                    Name = "* Testosterone"
                },
                new Laboratory
                {
                    Id = 102,
                    Name = "* Thyroglobulin"
                },
                new Laboratory
                {
                    Id = 103,
                    Name = "Thyroid Panel"
                },
                new Laboratory
                {
                    Id = 104,
                    Name = "Thyroid - stimulating Hormone(TSH)"
                },
                new Laboratory
                {
                    Id = 105,
                    Name = "Thyroxine(T4)"
                },
                new Laboratory
                {
                    Id = 106,
                    Name = "SGOT / ASAT"
                },
                new Laboratory
                {
                    Id = 107,
                    Name = "Random Blood Sugar(RBS)"
                },
                new Laboratory
                {
                    Id = 108,
                    Name = "SGPT / ALAT"
                },
                new Laboratory
                {
                    Id = 109,
                    Name = "* Rheumatoid Factor(RA / RF)"
                },
                new Laboratory
                {
                    Id = 110,
                    Name = "Stool Exam(S / E)"
                },
                new Laboratory
                {
                    Id = 111,
                    Name = "Sodium(Urine Na +)"
                },
                new Laboratory
                {
                    Id = 112,
                    Name = "Sodium(Blood Na +)"
                },
                new Laboratory
                {
                    Id = 113,
                    Name = "* Progesterone"
                },
                new Laboratory
                {
                    Id = 114,
                    Name = "Prostate - Specific Ag(PSA Qualitative)"
                },
                new Laboratory
                {
                    Id = 115,
                    Name = "* Prolcatin"
                },
                new Laboratory
                {
                    Id = 116,
                    Name = "* Prostate - Specific Ag(PSA Quantitative)"
                },
                new Laboratory
                {
                    Id = 117,
                    Name = "Protein Albumin(Urine)"
                },
                new Laboratory
                {
                    Id = 118,
                    Name = "Reticulocyte Count(Retic.Ct.)"
                },
                new Laboratory
                {
                    Id = 119,
                    Name = "Triiodothyronine(T3)"
                },
                new Laboratory
                {
                    Id = 120,
                    Name = "Triglycerides"
                },
                new Laboratory
                {
                    Id = 121,
                    Name = "TPHA"
                },
                new Laboratory
                {
                    Id = 122,
                    Name = "Total Protein(TP)"
                },
                new Laboratory
                {
                    Id = 123,
                    Name = "* Total CPK NAC"
                },
                new Laboratory
                {
                    Id = 124,
                    Name = "Semen Analysis"
                },
                new Laboratory
                {
                    Id = 125,
                    Name = "PTPA - Protime / Prothrombin Time"
                },
                new Laboratory
                {
                    Id = 126,
                    Name = "Wet Mount"
                },
                new Laboratory
                {
                    Id = 127,
                    Name = "Thphidot"
                },
                new Laboratory
                {
                    Id = 128,
                    Name = "White Blood Cell Differential Count(WBC Diff.Count)"
                },
                new Laboratory
                {
                    Id = 129,
                    Name = "Widal 5 Ags"
                },
                new Laboratory
                {
                    Id = 130,
                    Name = "Uric Acid(Urine"
                },
                new Laboratory
                {
                    Id = 131,
                    Name = "White Blood Cell Count(WBC Ct.)"
                },
                new Laboratory
                {
                    Id = 132,
                    Name = "* Urobilinogen"
                },
                new Laboratory
                {
                    Id = 133,
                    Name = "VDRL"
                },
                new Laboratory
                {
                    Id = 134,
                    Name = "Urinalysis(U / A)"
                },
                new Laboratory
                {
                    Id = 135,
                    Name = "* Troponin I(Trop.I)"
                },
                new Laboratory
                {
                    Id = 136,
                    Name = "* Troponin T(Trop.T)"
                },
                new Laboratory
                {
                    Id = 137,
                    Name = "Tuberculosis Ab(TB Ab)"
                }
            );
        }
    }
}
