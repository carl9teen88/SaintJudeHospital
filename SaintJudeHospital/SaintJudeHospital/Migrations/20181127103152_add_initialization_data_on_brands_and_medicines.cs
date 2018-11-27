using Microsoft.EntityFrameworkCore.Migrations;

namespace SaintJudeHospital.Migrations
{
    public partial class add_initialization_data_on_brands_and_medicines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Activent" },
                    { 100, "Omepron" },
                    { 101, "Opigesic" },
                    { 102, "Optipred" },
                    { 103, "Orastin" },
                    { 104, "Pediachlor" },
                    { 105, "Pediamox" },
                    { 106, "Pediatapp" },
                    { 107, "Penachlor" },
                    { 108, "Pharex" },
                    { 109, "Physiogel" },
                    { 110, "Polypen" },
                    { 111, "Ponstan" },
                    { 112, "Poro" },
                    { 113, "Pred 10" },
                    { 114, "Pred 20" },
                    { 99, "Nuelin" },
                    { 115, "Propan Tlc" },
                    { 98, "Neozep" },
                    { 96, "Nasoclear" },
                    { 80, "Loviscol" },
                    { 81, "Maalox" },
                    { 82, "Medicol" },
                    { 84, "Montemax" },
                    { 85, "Montiget" },
                    { 86, "Motilium" },
                    { 87, "Movelax" },
                    { 88, "Muconase" },
                    { 89, "Mucosolvan" },
                    { 90, "Myonal" },
                    { 91, "Myremol" },
                    { 92, "Napran" },
                    { 93, "Naprex" },
                    { 94, "Nasatapp" },
                    { 95, "Nasathera" },
                    { 97, "Natravox" },
                    { 116, "Prostaphlin-A" },
                    { 117, "Provexcel" },
                    { 118, "Prox-S" },
                    { 139, "Ultraxime" },
                    { 140, "Ventolin" },
                    { 141, "Ventolin Expt" },
                    { 142, "Virlix" },
                    { 143, "Vometa" },
                    { 144, "Xelent" },
                    { 145, "Xinflex" },
                    { 146, "Xyzal" },
                    { 147, "Zeditapp" },
                    { 148, "Zegen" },
                    { 149, "Zenith" },
                    { 150, "Zinnat" },
                    { 151, "Zithromax" },
                    { 152, "Zovirax" },
                    { 153, "Zyrtec" },
                    { 138, "Trizole" },
                    { 137, "Tergecet" },
                    { 136, "Tempra" },
                    { 135, "Sumapen" },
                    { 119, "Pulmodual" },
                    { 120, "Pulmoxcel" },
                    { 121, "Restime" },
                    { 122, "Ritemed" },
                    { 123, "Rodazid" },
                    { 124, "Romamed" },
                    { 125, "Rotocin" },
                    { 79, "Locetar" },
                    { 126, "Salinase" },
                    { 128, "Selzef" },
                    { 129, "Seretide" },
                    { 130, "Singulair" },
                    { 131, "Skelan" },
                    { 132, "Solmux" },
                    { 133, "Solmux Broncho" },
                    { 134, "Stafloxin" },
                    { 127, "Sangobion" },
                    { 78, "Klaz" },
                    { 83, "Meptin" },
                    { 76, "Katrex" },
                    { 22, "Bambec" },
                    { 23, "Bioclauid" },
                    { 24, "Biogesic" },
                    { 25, "Bricanyl" },
                    { 26, "Broncaire Expt" },
                    { 27, "Bronchofen" },
                    { 28, "Calmoseptine" },
                    { 29, "Calpol" },
                    { 30, "Ceclor" },
                    { 31, "Cefalin" },
                    { 32, "Ceporex" },
                    { 77, "Klarizid" },
                    { 34, "Chloromycetin" },
                    { 35, "Clariget" },
                    { 36, "Clarithro-Natrapharm Klaryz" },
                    { 21, "Bactroban" },
                    { 20, "Bacidal" },
                    { 19, "Azith" },
                    { 18, "Avamys" },
                    { 2, "Advil" },
                    { 3, "Allerkid" },
                    { 4, "Alloxygen" },
                    { 5, "Alnix" },
                    { 6, "Alvedon" },
                    { 7, "Ambrolex" },
                    { 8, "Amoclav" },
                    { 37, "Clarithro-natrapharm" },
                    { 9, "Amoxil" },
                    { 11, "Ansimar" },
                    { 12, "Antiox" },
                    { 13, "Asfrenon" },
                    { 14, "Asfrenon Expt" },
                    { 15, "Asmalin" },
                    { 16, "Asmalin Broncho" },
                    { 17, "Augmentin" },
                    { 10, "Ampicin" },
                    { 38, "Clarithrocid" },
                    { 33, "Cherifer" },
                    { 40, "Combantrin" },
                    { 61, "Fucidin" },
                    { 62, "Fucidin-h" },
                    { 63, "Fucithalmic" },
                    { 39, "Clotrasone" },
                    { 65, "Garamycin" },
                    { 66, "Gardan" },
                    { 67, "Heraclene" },
                    { 68, "Himox" },
                    { 69, "Hisdec" },
                    { 70, "Hydrite" },
                    { 71, "Ilosone" },
                    { 72, "Immunosine" },
                    { 73, "Iterax" },
                    { 74, "Jetepar" },
                    { 75, "Kastair" },
                    { 60, "Fluimucil" },
                    { 59, "Flanax" },
                    { 64, "Furoxone" },
                    { 57, "Faspic" },
                    { 41, "Combivent" },
                    { 42, "Daktarin" },
                    { 58, "Flagyl" },
                    { 44, "Dg" },
                    { 45, "Dilatair" },
                    { 46, "Dimetapp" },
                    { 47, "Disudrin" },
                    { 48, "Dolan" },
                    { 43, "Dalacin C" },
                    { 50, "Duavent" },
                    { 51, "E Zinc" },
                    { 52, "Elica" },
                    { 53, "Erceflora" },
                    { 54, "Ercefuryl" },
                    { 55, "Essentiale Forte" },
                    { 56, "Expel" },
                    { 49, "Dolfenal" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "BrandId", "Description", "GenericName", "Inscription" },
                values: new object[,]
                {
                    { 11, null, null, "Glycerin", "Pediatric suppository" },
                    { 10, null, null, "Broncho Vaxom", "Pedia Cap" },
                    { 9, null, "40mg/5ml", "Gentamicin IV", "Amp" },
                    { 8, null, "80mg/5ml", "Gentamicin IV", "Amp" },
                    { 7, null, "5mg", "Prednisolone", "Tab" },
                    { 3, null, "250mg", "Amoxicillin", "Cap" },
                    { 5, null, "30mg", "Prednisolone", "Tab" },
                    { 4, null, "375mg", "Co Amoxiclav", "Tab" },
                    { 2, null, "500mg", "Amoxicillin", "Cap" },
                    { 1, null, "10mg", "Cetirizine", "Tab" },
                    { 12, null, null, "Glycerin", "Pediatric suppository" },
                    { 6, null, "20mg", "Prednisolone", "Tab" },
                    { 21, null, "1.5mg/5ml", "Terbutaline", "Syrup" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "BrandId", "Description", "GenericName", "Inscription" },
                values: new object[,]
                {
                    { 13, 1, "2mg", "Salbutamol", "Tab" },
                    { 243, 106, null, "Brompheniramine Maleate + Phenylpropanolamine", "Drops" },
                    { 242, 106, null, "Brompheniramine Maleate + Phenylpropanolamine", "Syrup" },
                    { 241, 105, "100mg/ml", "Amoxicillin", "Drops" },
                    { 240, 105, "125mg/5ml", "Amoxicillin", "Susp" },
                    { 239, 105, "250mg/5ml", "Amoxicillin", "Susp" },
                    { 238, 104, "500mg", "Chloramphenicol", "Cap" },
                    { 237, 104, "250mg/5ml", "Chloramphenicol", "Cap" },
                    { 236, 104, "125mg/5ml", "Chloramphenicol", "Susp" },
                    { 235, 103, "100,000 Iu", "Nystatin", "Susp" },
                    { 234, 102, "20mg/5ml", "Prednisolone", "Syrup" },
                    { 233, 101, "250mg/5ml", "Paracetamol", "Suppository" },
                    { 232, 101, "125mg", "Paracetamol", "Suppository" },
                    { 231, 100, "20 Mg", "Omeprazole", "Cap" },
                    { 230, 99, "26.7mg/5ml", "Theophylline", "Syrup" },
                    { 229, 98, null, "Phenylephrine Hcl + Chlorpheniramine Maleate", "Drops" },
                    { 228, 98, null, "Phenylephrine Hcl + Chlorpheniramine Maleate", "Syrup" },
                    { 227, 97, "250mg/5ml", "Co Amoxiclav", "Susp" },
                    { 244, 107, "125mg/5ml", "Chloramphenicol", "Syrup" },
                    { 245, 107, "250mg", "Chloramphenicol", "Cap" },
                    { 246, 107, "500mg", "Chloramphenicol", "Cap" },
                    { 247, 108, "250mg/5ml", "Cloxacillin", "Susp" },
                    { 265, 116, "250mg/5ml", "Cloxacillin", "Susp" },
                    { 264, 115, null, "Multivitamins", "Syrup" },
                    { 263, 114, "20mg/5ml", "Prednisolone", "Syrup" },
                    { 262, 113, "10mg/5ml", "Prednisone", "Syrup" },
                    { 261, 113, null, "Prednisone", null },
                    { 260, 112, "250mg", "Paracetamol", "Suppository" },
                    { 259, 112, "125mg", "Paracetamol", "Suppository" },
                    { 258, 111, "250mg", "Mefenamic Acid", "Cap" },
                    { 226, 97, "125mg/5ml", "Co Amoxiclav", "Susp" },
                    { 257, 111, "50mg/5ml", "Mefenamic Acid", "Susp" },
                    { 255, 110, "250mg", "Ampicillin IV", null },
                    { 254, 110, "500mg", "Ampicillin IV", null },
                    { 253, 110, "750mg", "Ampicillin IV", null },
                    { 252, 110, "1gm", "Ampicillin IV", null },
                    { 251, 109, null, "Physiogel ", "Ai Lotion" },
                    { 250, 109, null, "Physiogel ", "Skin Cleanser" },
                    { 249, 108, "125mg/5ml", "Cloxacillin", "Susp" },
                    { 248, 108, "250mg/5ml", "Cloxacillin", "Susp" },
                    { 256, 111, "500mg", "Mefenamic Acid", "Cap" },
                    { 266, 116, "250mg/5ml", "Cloxacillin", "Susp" },
                    { 225, 96, null, "Sodium Chloride", "Nasal drops" },
                    { 223, 95, "325mg/25mg", "Paracetamol + Phenylpropanolamine", "Cap" },
                    { 203, 85, "5mg", "Montelukast", "Tab" },
                    { 202, 84, "4mg", "Montelukast", "Tab" },
                    { 201, 84, "10mg", "Montelukast", "Tab" },
                    { 200, 84, "5mg", "Montelukast", "Tab" },
                    { 199, 83, "5mgm/ml", "Procaterol", "Syrup" },
                    { 198, 83, "50mgm", "Procaterol", "Tab" },
                    { 197, 83, "25mgm", "Procaterol", "Tab" },
                    { 196, 82, "200mg", "Ibuprofen", "Cap" },
                    { 195, 81, null, "Aluminum Magnesium Hydroxide", "Susp" },
                    { 194, 81, null, "Aluminum Magnesium Hydroxide", "Tab" },
                    { 193, 80, "50mg/ml", "Carbocisteine", "Drops" },
                    { 192, 80, "100mg/5ml", "Carbocisteine", "Syrup" },
                    { 191, 79, null, "Amorolfine", "Nail Lacquer" },
                    { 190, 78, "250mg", "Clarithromycin", "Tab" },
                    { 189, 78, "125mg/5ml", "Clarithromycin", "Susp" },
                    { 188, 78, "250mg/5ml", "Clarithromycin", "Susp" },
                    { 187, 78, "500mg", "Clarithromycin", "Tab" },
                    { 204, 85, "10mg", "Montelukast", "Tab" },
                    { 205, 85, "4mg", "Montelukast", "Tab" },
                    { 206, 85, "4mg", "Montelukast", "Granules" },
                    { 207, 86, "10mg", "Domperidone", "Tab" },
                    { 222, 95, "250mg/12.5mg", "Paracetamol + Phenylpropanolamine", "Syrup" },
                    { 221, 94, null, "Brompheniramine Maleate + Phenylpropanolamine", "Drops" },
                    { 220, 94, null, "Brompheniramine Maleate + Phenylpropanolamine", "Syrup" },
                    { 219, 93, "100mg/ml", "Paracetamol", "Drops" },
                    { 218, 93, "250mg/5ml", "Paracetamol", "Syrup" },
                    { 217, 92, "250mg/5ml", "Paracetamol", "Syrup" },
                    { 216, 92, "100ml", "Paracetamol", "Drops" },
                    { 215, 91, "100ml", "Paracetamol", "Drops" },
                    { 224, 96, null, "Sodium Chloride", "Nasal spray" },
                    { 214, 91, "250mg/5ml", "Paracetamol", "Syrup" },
                    { 212, 90, "50mg", "Eperisone HCI", "Tab" },
                    { 356, 89, "15mg/5ml", "Ambroxol", "Syrup" },
                    { 355, 89, "30mg/5ml", "Ambroxol", "Syrup" },
                    { 354, 89, "30mg", "Ambroxol", "Tab" },
                    { 211, 89, "7.5mg/ml", "Ambroxol", "Drops" },
                    { 210, 88, null, "Sodium Chloride", "Nasal spray" },
                    { 209, 88, null, "Sodium Chloride", "Nasal drops" },
                    { 208, 87, "3.3g/5ml", "Lactulose", "Syrup" },
                    { 213, 91, "120mg/5ml", "Paracetamol", "Syrup" },
                    { 186, 77, "250mg/5ml", "Clarithromycin", "Susp" },
                    { 267, 116, "125mg/5ml", "Cloxacillin", "Susp" },
                    { 269, 118, "2mg", "Salbutamol", "Tab" },
                    { 329, 143, "5mg/5ml", "Domperidone", "Syrup" },
                    { 328, 143, "5mg/ml", "Domperidone", "Drops" },
                    { 327, 142, "1mg/ml", "Cetirizine", "Solution" },
                    { 326, 142, "10mg/ml", "Cetirizine", "Drops" },
                    { 325, 141, null, "Salbutamol + Guaifenesin", "Syrup" },
                    { 324, 140, "2mg", "Salbutamol", "Tab" },
                    { 323, 140, "100mgm/Inhalation", "Salbutamol", "MDI" },
                    { 322, 140, "2.5mg/2.5ml", "Salbutamol", "Nebule" },
                    { 321, 139, "100mg", "Cefixime", "Cap" },
                    { 320, 139, "100mg/5ml", "Cefixime", "Drops" },
                    { 319, 139, "20mg/ml", "Cefixime", "Drops" },
                    { 318, 139, "200mg", "Cefixime", "Cap" },
                    { 317, 138, "400mg/80/5ml", "Cotrimoxazole", "Susp" },
                    { 316, 137, "20mg/ml", "Cefixime", "Drops" },
                    { 315, 137, "200mg", "Cefixime", "Cap" },
                    { 314, 137, "100mg/5ml", "Cefixime", "Susp" },
                    { 313, 137, "100mg", "Cefixime", "Cap" },
                    { 330, 144, "125mg/5ml", "Cefaclor", "Susp" },
                    { 331, 144, "250mg/5ml", "Cefaclor", "Susp" },
                    { 332, 144, "50mg/ml", "Cefaclor", "Drops" },
                    { 333, 145, "250mg/5ml", "Cefalexin", "Susp" },
                    { 351, 152, "200mg", "Acyclovir", "Tab" },
                    { 350, 152, "400mg", "Acyclovir", "Tab" },
                    { 349, 152, "250mg", "Azithromycin", "Tab" },
                    { 348, 151, "200mg/5ml", "Azithromycin", "Susp" },
                    { 347, 151, "500mg", "Azithromycin", "Tab" },
                    { 346, 150, "125mg/5ml", "Cefuroxime", "Susp" },
                    { 345, 150, "250mg/5ml", "Cefuroxime", "Susp" },
                    { 344, 149, "200mg/5ml", "Azithromycin", "Susp" },
                    { 312, 136, "100mg/ml", "Paracetamol", "Drops" },
                    { 343, 149, "250mg", "Azithromycin", "Tab" },
                    { 341, 148, "250mg", "Cefuroxime", "Cap" },
                    { 340, 147, null, "Brompheniramine Maleate + Phenylpropanolamine", "Syrup" },
                    { 339, 147, null, "Brompheniramine Maleate + Phenylpropanolamine", "Drops" },
                    { 338, 146, "5mg/ml", "Levocetirizine Diltci", "Drops" },
                    { 337, 146, "5mg", "Levocetirizine Diltci", "Tab" },
                    { 336, 146, "5mg/ml", "Levocetirizine Diltci", "Syrup" },
                    { 335, 145, "100mg/ml", "Cefalexin", "Drops" },
                    { 334, 145, "125mg/5ml", "Cefalexin", "Susp" },
                    { 342, 149, "500mg", "Azithromycin", "Tab" },
                    { 268, 117, "2.5mg/2.5ml", "Salbutamol", "Nebule" },
                    { 311, 136, "325mg", "Paracetamol", "Tab" },
                    { 309, 136, "250mg/5ml", "Paracetamol", "Syrup" },
                    { 286, 128, "250mg/5ml", "Cefalexin", "Susp" },
                    { 285, 127, null, "Ferrous Gluconate", "Syrup" },
                    { 284, 126, null, "Sodium Chloride", "Nasal drops" },
                    { 283, 126, null, "Sodium Chloride", "Nasal spray" },
                    { 282, 125, "500mg", "Ampicillin IV", null },
                    { 281, 125, "750mg", "Ampicillin IV", null },
                    { 280, 125, "1gm", "Ampicillin IV", null },
                    { 279, 125, "250mg", "Ampicillin IV", null },
                    { 278, 124, "20mg/5ml", "Prednisolone", "Syrup" },
                    { 277, 123, "125mg/5ml", "Metronidazole", "Syrup" },
                    { 276, 122, "125mg/5ml", "Cloxacillin", "Susp" },
                    { 275, 122, "250mg/5ml", "Cloxacillin", "Susp" },
                    { 274, 122, "250mg/5ml", "Cloxacillin", "Susp" },
                    { 273, 121, null, "Simethicone", "Drops" },
                    { 272, 120, "1.5mg/5ml", "Terbutaline ", "Syrup" },
                    { 271, 119, null, "Salbutamol + Ipratropium Bromide", "Nebule" },
                    { 270, 118, "2mg/5ml", "Salbutamol", "Syrup" },
                    { 287, 128, "125mg/5ml", "Cefalexin", "Susp" },
                    { 288, 128, "100mg/ml", "Cefalexin", "Drops" },
                    { 289, 129, "25/250", "Salmeterol + Fluticasone Propionate", "MDI" },
                    { 290, 129, "25/125", "Salmeterol + Fluticasone Propionate", "MDI" },
                    { 308, 136, "250mg", "Paracetamol", "Tab" },
                    { 307, 136, "120mg/5ml", "Paracetamol", "Syrup" },
                    { 306, 136, "250mg/5ml", "Paracetamol", "Susp" },
                    { 305, 135, "500mg", "Phenoxymethylpenicillin K", "Cap" },
                    { 304, 135, "250mg", "Phenoxymethylpenicillin K", "Cap" },
                    { 303, 134, "125mg/5ml", "Fluocloxacillin", "Susp" },
                    { 302, 134, "250mg", "Fluocloxacillin", "Cap" },
                    { 301, 134, "500mg", "Fluocloxacillin", "Cap" },
                    { 310, 136, "500mg", "Paracetamol", "Tab" },
                    { 300, 133, null, "Salbutamol + Guaifenesin", "Syrup" },
                    { 298, 132, "100mg/5ml", "Carbocisteine", "Syrup" },
                    { 297, 131, "275mg", "Naproxen Sodium", "Tab" },
                    { 296, 131, "550mg", "Naproxen Sodium", "Tab" },
                    { 295, 130, "4mg", "Montelukast", "Glanules" },
                    { 294, 130, "4mg", "Montelukast", "Tab" },
                    { 293, 130, "5mg", "Montelukast", "Tab" },
                    { 292, 130, "10mg", "Montelukast", "Tab" },
                    { 291, 129, "25/50", "Salmeterol + Fluticasone Propionate", "MDI" },
                    { 299, 132, "50mg/ml", "Carbocisteine", "Drops" },
                    { 352, 153, "10mg/ml", "Cetirizine", "Drops" },
                    { 185, 77, "250mg", "Clarithromycin", "Tab" },
                    { 183, 77, "500mg", "Clarithromycin", "Tab" },
                    { 74, 24, "500mg", "Paracetamol", "Tab" },
                    { 73, 24, "120mg/5ml", "Paracetamol", "Susp" },
                    { 72, 23, "250mg/5ml", "Co Amoxiclav", "Susp" },
                    { 71, 23, "125mg/5ml", "Co Amoxiclav", "Susp" },
                    { 70, 22, "10mg", "Bambuterol", "Tab" },
                    { 69, 22, "1mg/1ml", "Bambuterol", "Syrup" },
                    { 68, 21, "Cream", "Mupirocin", "Tube" },
                    { 67, 20, "4oomg/80mg", "Cotrimoxazole", "Tab" },
                    { 66, 19, "200mg/5ml", "Azithromycin", "Susp" },
                    { 65, 19, "250mg", "Azithromycin", "Tab" },
                    { 64, 19, "500mg", "Azithromycin", "Tab" },
                    { 63, 18, "27.5mgm/spray", "Fluticasone Furoate", "Nasal Spray" },
                    { 62, 17, "312mg/5ml", "Coamoxiclav", "Susp" },
                    { 61, 17, "228mg/5ml", "Coamoxiclav", "Susp" },
                    { 60, 17, "457mg/5ml", "Coamoxiclav", "Susp" },
                    { 59, 17, "156mg/5ml", "Coamoxiclav", "Susp" },
                    { 58, 17, "625mg", "Coamoxiclav", "Tab" },
                    { 75, 24, "250mg/5ml", "Paracetamol", "Syrup" },
                    { 76, 24, "250mg", "Paracetamol", "Tab" },
                    { 77, 24, "325mg", "Paracetamol", "Tab" },
                    { 78, 24, "100mg/ml", "Paracetamol", "Drops" },
                    { 96, 31, "125mg/5ml", "Cefalexin", "Susp" },
                    { 95, 31, "250mg/5ml", "Cefalexin", "Susp" },
                    { 94, 31, "500mg", "Cefalexin", "Cap" },
                    { 93, 30, "50mg/ml", "Cefaclor + Guaifenesin", "Drops" },
                    { 92, 30, "125mg/5ml", "Cefaclor", "Susp" },
                    { 91, 30, "250mg/5ml", "Cefaclor", "Susp" },
                    { 90, 29, "100mg/ml", "Paracetamol", "Drops" },
                    { 89, 29, "120mg/5ml", "Paracetamol", "Syrup" },
                    { 57, 16, null, "Salbutamol + Guaifenesin", "Syrup" },
                    { 88, 29, "325mg", "Paracetamol", "Tab" },
                    { 86, 29, "250mg", "Paracetamol", "Tab" },
                    { 85, 29, "250mg/5ml", "Paracetamol", "Susp" },
                    { 84, 28, "Sachet", "Calmoseptine", "Ointment" },
                    { 83, 27, null, "Phenylephrine Hcl + Chlorpheniramine Maleate", "drops" },
                    { 82, 27, null, "Phenylephrine Hcl + Chlorpheniramine Maleate", "Syrup" },
                    { 81, 27, "5mg///1mg/5ml", "Phenylephrine Hcl + Chlorpheniramine Maleate", "Syrup" },
                    { 80, 26, null, "Salbutamol + Guaifenesin", "Syrup" },
                    { 79, 25, "1.5mg/5ml", "Terbutaline", "Syrup" },
                    { 87, 29, "500mg", "Paracetamol", "Tab" },
                    { 97, 31, "100mg/ml", "Cefalexin", "Drops" },
                    { 56, 15, "2mg/5ml", "Salbutamol", "Syrup" },
                    { 54, 15, "2.5mg/2.5ml", "Salbutamol", "Nebule" },
                    { 31, 7, "30mg/3ml", "Ambroxol", "Syrup" },
                    { 30, 7, "30mg", "Ambroxol", "Tab" },
                    { 29, 6, "100ml", "Paracetamol", "Drops" },
                    { 28, 6, "120mg/5ml", "Paracetamol", "Syrup" },
                    { 27, 5, "500mg", "Paracetamol", "Tab" },
                    { 26, 5, "325mg", "Paracetamol", "Tab" },
                    { 25, 5, "250mg", "Paracetamol", "Tab" },
                    { 24, 5, "2.5mg/ml", "Cetirizine", "Drops" },
                    { 23, 4, "5mg/5ml", "Cetirizine", "Syrup" },
                    { 22, 4, "10mg", "Cetirizine", "Tab" },
                    { 20, 3, "2.5mg/ml", "Cetirizine", "Drops" },
                    { 19, 3, "5mg/5ml", "Cetirizine", "Syrup" },
                    { 18, 2, "100mg/2.5ml", "Ibuprofen", "Drops" },
                    { 17, 2, "200mg", "Ibuprofen", "Cap" },
                    { 16, 2, "200mg/5ml", "Ibuprofen", "Susp" },
                    { 15, 2, "100mg/5ml", "Ibuprofen", "Susp" },
                    { 14, 1, "2mg/5ml", "Salbutamol", "Syrup" },
                    { 32, 7, "15mg/5ml", "Ambroxol", "Syrup" },
                    { 33, 7, "7.5mg/ml", "Ambroxol", "Drops" },
                    { 34, 8, "457mg/5ml", "Co Amoxiclav", "Susp" },
                    { 35, 8, "228mg/5ml", "Co Amoxiclav", "Susp" },
                    { 53, 15, "100mgm/Inhalation", "Salbutamol", "MDI" },
                    { 52, 14, null, "Salbutamol + Guaifenesin", "Syrup" },
                    { 51, 13, "2mg/5ml", "Salbutamol", "Syrup" },
                    { 50, 12, "50mg/ml", "Mebendazole", "Susp" },
                    { 49, 12, "500mg", "Mebendazole", "Tab" },
                    { 48, 12, "20mg/ml", "Mebendazole", "Susp" },
                    { 47, 12, "100mg", "Mebendazole", "Tab" },
                    { 46, 11, "100mg/5ml", "Doxofylline", "Syrup" },
                    { 55, 15, "2mg", "Salbutamol", "Tab" },
                    { 45, 11, "100mg", "Doxofylline", "Tab" },
                    { 43, 10, "750mg", "Ampicillin IV", null },
                    { 42, 10, "500mg", "Ampicillin IV", null },
                    { 41, 10, "1mg", "Ampicillin IV", null },
                    { 40, 9, "125mg/ml", "Amoxicillin", "Susp" },
                    { 39, 9, "100mg/ml", "Amoxicillin", "Drops" },
                    { 38, 9, "250mg/5ml", "Amoxicillin", "Susp" },
                    { 37, 8, "312mg/5ml", "Co Amoxiclav", "Susp" },
                    { 36, 8, "156mg/5ml", "Co Amoxiclav", "Susp" },
                    { 44, 10, "250mg", "Ampicillin IV", null },
                    { 184, 77, "125mg/5ml", "Clarithromycin", "Susp" },
                    { 98, 32, "250mg/5ml", "Cefalexin", "Susp" },
                    { 100, 32, "100mg/ml", "Cefalexin", "Drops" },
                    { 160, 65, null, "Gentamycin", "Eyedrops" },
                    { 159, 64, "16.7mg/5ml", "Furazolidone", "Susp" },
                    { 158, 64, "100mg", "Furazolidone", "Tab" },
                    { 157, 63, "Tube", "Fucidic Acid", "Eyedrops" },
                    { 156, 62, "Tube", "Fucidic Acid + Hydrocortisone", "Ointment" },
                    { 155, 61, "Tube", "Fusidate Sodium", "Ointment" },
                    { 154, 60, "200mg", "Acetylcysteine", "Sachet" },
                    { 153, 60, "100mg/5ml", "Acetylcysteine", "Syrup" },
                    { 152, 60, "1000mg", "Acetylcysteine", "Sachet" },
                    { 151, 59, "275mg", "Naproxen Sodium", "Tab" },
                    { 150, 59, "550mg", "Naproxen Sodium", "Tab" },
                    { 149, 58, null, "Metronidazole", null },
                    { 148, 58, "25mg/1ml", "Metronidazole", "Syrup" },
                    { 147, 58, "500mg", "Metronidazole", "Tab" },
                    { 146, 57, "200mg", "Ibuprofen", "Cap" },
                    { 145, 57, "400mg", "Ibuprofen", "Cap" },
                    { 144, 56, "15mg/2.5ml", "Ambroxol", "Syrup" },
                    { 161, 66, "500mg", "Mefenamic Acid", "Cap" },
                    { 162, 66, "250mg", "Mefenamic Acid", "Cap" },
                    { 163, 67, "1mg/1ml", "Dibencozide", "Cap" },
                    { 164, 68, "500mg", "Amoxicillin", "Cap" },
                    { 182, 76, "200mg/40mg/5ml", "Cotrimoxazole", "Bot" },
                    { 181, 75, "5mg", "Montelukast", "Tab" },
                    { 180, 75, "10mg", "Montelukast", "Tab" },
                    { 179, 75, "4mg", "Montelukast", "Tab" },
                    { 178, 74, null, "Betaine Glucuronate Plus", "Cap" },
                    { 177, 74, null, "Betaine Glucuronate Plus", "Syrup" },
                    { 176, 73, "10mg", "Hydroxyzine diHCI", "Tab" },
                    { 175, 73, "2mg/ml", "Hydroxyzine diHCI", "Syrup" },
                    { 143, 56, "7.5mg/5ml", "Ambroxol", "Drops" },
                    { 174, 73, "25mg", "Hydroxyzine diHCI", "Tab" },
                    { 172, 71, "100mg/ml", "Erythromycin", "Drops" },
                    { 171, 71, "250mg/5ml", "Erythromycin", "Susp" },
                    { 170, 70, null, "Oral Rehydration Solution", "Sachet" },
                    { 169, 69, null, "Brompheniramine Maleate + Phenylpropanolamine", "Drops" },
                    { 168, 69, null, "Brompheniramine Maleate + Phenylpropanolamine", "Syrup" },
                    { 167, 68, "100mg/ml", "Amoxicillin", "Drops" },
                    { 166, 68, "125mg/5ml", "Amoxicillin", "Susp" },
                    { 165, 68, "250mg/5ml", "Amoxicillin", "Susp" },
                    { 173, 72, "Bot", "Inosiplex", "Syrup" },
                    { 99, 32, "125mg/5ml", "Cefalexin", "Susp" },
                    { 142, 56, "30mg/5ml", "Ambroxol", "Syrup" },
                    { 140, 55, "300mg", "Phospholipids", "Cap" },
                    { 117, 41, null, "Salbutamol + Ipratropium Bromide", "Nebule" },
                    { 116, 40, "125mg/5ml", "Pyrantel Pamoate", "Susp" },
                    { 115, 40, "125mg", "Pyrantel Pamoate", "Tab" },
                    { 114, 39, "Tube", "Clotrimazole + Betamethasone", "Cream" },
                    { 113, 38, "125mg/5ml", "Clarithromycin", "Susp" },
                    { 112, 38, "250mg/5ml", "Clarithromycin", "Susp" },
                    { 111, 38, "500mg", "Clarithromycin", "Tab" },
                    { 110, 38, "250mg", "Clarithromycin", "Tab" },
                    { 109, 37, "125mg/5ml", "Clarithromycin", "Susp" },
                    { 108, 36, "250mg/5ml", "Clarithromycin", "Susp" },
                    { 107, 36, "500mg", "Clarithromycin", "Tab" },
                    { 106, 36, "125mg/5ml", "Clarithromycin", "Tab" },
                    { 105, 35, "125mg/5ml", "Clarithromycin", "Susp" },
                    { 104, 34, "250mg", "Chloramphenicol", "Cap" },
                    { 103, 34, "125mg/5ml", "Chloramphenicol", "Susp" },
                    { 102, 34, "500mg", "Chloramphenicol", "Cap" },
                    { 101, 33, null, "Multivitamins", "Drops" },
                    { 118, 42, "Tube", "Miconazole", "Oral Gel" },
                    { 119, 43, "75mg/5ml", "Clindamycin", "Susp" },
                    { 120, 44, "400mg", "Dg Milk", "Can" },
                    { 121, 45, "100mg/5ml", "Doxofylline", "Syrup" },
                    { 139, 54, "200mg", "Nifuroxazide", "Cap" },
                    { 138, 54, "218mg/5ml", "Nifuroxazide", "Susp" },
                    { 137, 53, null, "Bacillus Clausii", "Oral Solution" },
                    { 136, 52, null, "Mometasone Furoate", "Cream" },
                    { 135, 52, null, "Mometasone Furoate", "Lotion" },
                    { 134, 51, null, "Zinc Sulfate", "Drops" },
                    { 133, 51, null, "Zinc Sulfate", "Syrup" },
                    { 132, 50, null, "Salbutamol + Ipratropium Bromide", "Nebule" },
                    { 141, 56, "300mg", "Ambroxol", "Tab" },
                    { 131, 49, "500mg", "Mefenamic Acid", "Cap" },
                    { 129, 48, "100mg/2.5ml", "Ibuprofen", "Drops" },
                    { 128, 48, "100mg/5ml", "Ibuprofen", "susp" },
                    { 127, 48, "200mg/5ml", "Ibuprofen", "Susp" },
                    { 126, 47, null, "Phenylpropanolamine", "Drops" },
                    { 125, 47, null, "Phenylpropanolamine", "Syrup" },
                    { 124, 46, null, "Brompheniramine Maleate + Phenylephrine", "Syrup" },
                    { 123, 46, null, "Brompheniramine Maleate + Phenylephrine", "Drops" },
                    { 122, 45, "100mg", "Doxofylline", "Tab" },
                    { 130, 49, "250mg", "Mefenamic Acid", "Cap" },
                    { 353, 153, "1mg/ml", "Cetirizine", "Solution" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153);
        }
    }
}
