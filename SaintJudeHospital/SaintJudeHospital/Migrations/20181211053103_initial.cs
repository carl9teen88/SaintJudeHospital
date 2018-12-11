using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaintJudeHospital.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Checkups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Subjective = table.Column<string>(nullable: true),
                    Objective = table.Column<string>(nullable: true),
                    Assessment = table.Column<string>(nullable: true),
                    Prescription = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    NextVisitDate = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    HeadCircum = table.Column<string>(nullable: true),
                    Temperature = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Diagnosis = table.Column<string>(nullable: true),
                    CivilStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Immunizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immunizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InPatients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InPatients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laboratories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symtoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symtoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaccineTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenericId = table.Column<int>(nullable: false),
                    InscriptionId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicines_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Medicines_Generics_GenericId",
                        column: x => x.GenericId,
                        principalTable: "Generics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicines_Inscriptions_InscriptionId",
                        column: x => x.InscriptionId,
                        principalTable: "Inscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CivilStatus = table.Column<string>(nullable: true),
                    PatientStatusId = table.Column<int>(nullable: false),
                    ParentId1 = table.Column<int>(nullable: true),
                    Parent1Id = table.Column<int>(nullable: true),
                    ParentId2 = table.Column<int>(nullable: true),
                    Parent2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Parents_Parent1Id",
                        column: x => x.Parent1Id,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Parents_Parent2Id",
                        column: x => x.Parent2Id,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_PatientStatuses_PatientStatusId",
                        column: x => x.PatientStatusId,
                        principalTable: "PatientStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Dose = table.Column<int>(nullable: false),
                    Booster = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    VaccineTypeId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccines_VaccineTypes_VaccineTypeId",
                        column: x => x.VaccineTypeId,
                        principalTable: "VaccineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckupId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    PayProcess = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ConsultationFee = table.Column<decimal>(nullable: false),
                    PPDFee = table.Column<decimal>(nullable: false),
                    FollowUpFee = table.Column<decimal>(nullable: false),
                    EarPiercingFee = table.Column<decimal>(nullable: false),
                    NebulizationFee = table.Column<decimal>(nullable: false),
                    VaccineInfo = table.Column<string>(nullable: true),
                    TotalPayment = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    BillStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_BillStatuses_BillStatusId",
                        column: x => x.BillStatusId,
                        principalTable: "BillStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Checkups_CheckupId",
                        column: x => x.CheckupId,
                        principalTable: "Checkups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCertificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PatientId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Diagnosis = table.Column<string>(nullable: true),
                    Operation = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Requestor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCertificates_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinePatients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VaccineId = table.Column<int>(nullable: false),
                    CheckupId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinePatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccinePatients_Checkups_CheckupId",
                        column: x => x.CheckupId,
                        principalTable: "Checkups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccinePatients_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccinePatients_Vaccines_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 95, "Nasathera" },
                    { 80, "Loviscol" },
                    { 81, "Maalox" },
                    { 82, "Medicol" },
                    { 83, "Meptin" },
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
                    { 96, "Nasoclear" },
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
                    { 97, "Natravox" },
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
                    { 33, "Cherifer" },
                    { 34, "Chloromycetin" },
                    { 35, "Clariget" },
                    { 36, "Clarithro-Natrapharm Klaryz" },
                    { 21, "Bactroban" },
                    { 20, "Bacidal" },
                    { 77, "Klarizid" },
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
                    { 19, "Azith" },
                    { 40, "Combantrin" },
                    { 60, "Fluimucil" },
                    { 61, "Fucidin" },
                    { 62, "Fucidin-h" },
                    { 63, "Fucithalmic" },
                    { 64, "Furoxone" },
                    { 65, "Garamycin" },
                    { 67, "Heraclene" },
                    { 59, "Flanax" },
                    { 68, "Himox" },
                    { 70, "Hydrite" },
                    { 71, "Ilosone" },
                    { 72, "Immunosine" },
                    { 73, "Iterax" },
                    { 74, "Jetepar" },
                    { 75, "Kastair" },
                    { 39, "Clotrasone" },
                    { 69, "Hisdec" },
                    { 58, "Flagyl" },
                    { 66, "Gardan" },
                    { 57, "Faspic" },
                    { 41, "Combivent" },
                    { 42, "Daktarin" },
                    { 43, "Dalacin C" },
                    { 44, "Dg" },
                    { 45, "Dilatair" },
                    { 47, "Disudrin" },
                    { 48, "Dolan" },
                    { 49, "Dolfenal" },
                    { 46, "Dimetapp" },
                    { 51, "E Zinc" },
                    { 52, "Elica" },
                    { 53, "Erceflora" },
                    { 54, "Ercefuryl" },
                    { 55, "Essentiale Forte" },
                    { 56, "Expel" },
                    { 50, "Duavent" }
                });

            migrationBuilder.InsertData(
                table: "Generics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 61, "Nystatin" },
                    { 55, "Mometasone Furoate" },
                    { 60, "Nifuroxazide" },
                    { 59, "Naproxen Sodium" },
                    { 58, "Mupirocin" },
                    { 57, "Multivitamins" },
                    { 56, "Montelukast" },
                    { 54, "Miconazole" },
                    { 46, "Hydroxyzine diHCI" },
                    { 52, "Mefenamic Acid" },
                    { 51, "Mebendazole" },
                    { 50, "Levocetirizine Diltci" },
                    { 49, "Lactulose" },
                    { 48, "Inosiplex" },
                    { 47, "Ibuprofen" },
                    { 45, "Glycerin" },
                    { 62, "Omeprazole" },
                    { 53, "Metronidazole" },
                    { 63, "Oral Rehydration Solution" },
                    { 82, "Theophylline" },
                    { 65, "Paracetamol + Phenylpropanolamine" },
                    { 44, "Gentamycin" },
                    { 83, "Zinc Sulfate" },
                    { 81, "Terbutaline" },
                    { 80, "Sodium Chloride" },
                    { 79, "Simethicone" },
                    { 78, "Salmeterol + Fluticasone Propionate" },
                    { 77, "Salbutamol + Ipratropium Bromide" },
                    { 76, "Salbutamol + Guaifenesin" },
                    { 64, "Paracetamol" },
                    { 75, "Salbutamol" },
                    { 73, "Procaterol" },
                    { 72, "Prednisone" },
                    { 71, "Prednisolone" },
                    { 70, "Physiogel" },
                    { 69, "Phospholipids" },
                    { 68, "Phenylpropanolamine" },
                    { 67, "Phenylephrine Hcl + Chlorpheniramine Maleate" },
                    { 66, "Phenoxymethylpenicillin K" },
                    { 74, "Pyrantel Pamoate" },
                    { 43, "Gentamicin IV" },
                    { 9, "Bacillus Clausii" },
                    { 41, "Furazolidone" },
                    { 18, "Cefaclor + Guaifenesin" },
                    { 17, "Cefaclor" },
                    { 16, "Carbocisteine" },
                    { 15, "Calmoseptine" },
                    { 14, "Broncho Vaxom" },
                    { 13, "Brompheniramine Maleate + Phenylpropanolamine" },
                    { 12, "Brompheniramine Maleate + Phenylephrine" },
                    { 11, "Betaine Glucuronate Plus" },
                    { 10, "Bambuterol" },
                    { 8, "Azithromycin" },
                    { 7, "Ampicillin IV" },
                    { 6, "Amoxicillin" },
                    { 5, "Amorolfine" },
                    { 3, "Aluminum Magnesium Hydroxide" },
                    { 2, "Acyclovir" },
                    { 1, "Acetylcysteine" },
                    { 42, "Fusidate Sodium" },
                    { 19, "Cefalexin" },
                    { 20, "Cefixime" },
                    { 4, "Ambroxol" },
                    { 22, "Cetirizine" },
                    { 21, "Cefuroxime" },
                    { 39, "Fucidic Acid" },
                    { 38, "Fluticasone Furoate" },
                    { 37, "Fluocloxacillin" },
                    { 36, "Ferrous Gluconate" },
                    { 34, "Eperisone HCI" },
                    { 33, "Doxofylline" },
                    { 40, "Fucidic Acid + Hydrocortisone" },
                    { 32, "Domperidone" },
                    { 35, "Erythromycin" },
                    { 30, "Dg Milk" },
                    { 29, "Cotrimoxazole" },
                    { 28, "Co Amoxiclav" },
                    { 23, "Chloramphenicol" },
                    { 27, "Cloxacillin" },
                    { 26, "Clotrimazole + Betamethasone" },
                    { 25, "Clindamycin" },
                    { 24, "Clarithromycin" },
                    { 31, "Dibencozide" }
                });

            migrationBuilder.InsertData(
                table: "Immunizes",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { 14, 3000m, "MMR-V" },
                    { 15, 1700m, "PNEUMO-23" },
                    { 16, 1700m, "RABIES" },
                    { 20, 4000m, "PCV" },
                    { 18, 2200m, "ROTATEQ" },
                    { 19, 1000m, "FLU" },
                    { 21, 0m, "BCG-2" },
                    { 13, 900m, "BCG-1" },
                    { 17, 3000m, "ROTARIX" },
                    { 12, 2500m, "PENTA" },
                    { 8, 700m, "HEP B" },
                    { 10, 1200m, "MMR" },
                    { 9, 1600m, "TETRAXIM" },
                    { 7, 1800m, "HEP A" },
                    { 6, 1300m, "TYPHOID" },
                    { 5, 4000m, "MENINGO" },
                    { 4, 1300m, "HIB" },
                    { 3, 750m, "MEASLES" },
                    { 2, 3200m, "PCV 10" },
                    { 1, 3000m, "HEXA" },
                    { 11, 2200m, "CHICKEN POX" }
                });

            migrationBuilder.InsertData(
                table: "Inscriptions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 17, "Pediatric Suppository" },
                    { 18, "Sachet" },
                    { 19, "Skin Cleanser" },
                    { 20, "Solution" },
                    { 21, "Suppository" },
                    { 22, "Suspension" },
                    { 28, "Can" },
                    { 24, "Tablet" },
                    { 25, "Tube" },
                    { 26, "Bottle" },
                    { 27, "Nasal Spray" },
                    { 16, "Pediatric Capsule" },
                    { 23, "Syrup" },
                    { 15, "Oral Solution" },
                    { 2, "Amp" },
                    { 13, "Ointment" },
                    { 14, "Oral Gel" },
                    { 1, "Ai Lotion" },
                    { 3, "Campsuele" },
                    { 5, "Drops" },
                    { 6, "Eyedrops" },
                    { 4, "Cream" },
                    { 8, "Lotion" },
                    { 9, "MDI" },
                    { 10, "Nail Lacquer" },
                    { 11, "Nasal Drops" },
                    { 12, "Nebule" },
                    { 7, "Granules" }
                });

            migrationBuilder.InsertData(
                table: "Symtoms",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 26, null, "Less appetite" },
                    { 21, null, "Muscle pain" },
                    { 22, null, "Skin lesions" },
                    { 23, null, "Trauma" },
                    { 24, null, "Pain urination" },
                    { 25, null, "Rushes" },
                    { 27, null, "LBM" },
                    { 33, null, "Urticarial rash" },
                    { 29, null, "Dysuria" },
                    { 30, null, "Rashes" },
                    { 31, null, "Dysphagia" },
                    { 32, null, "Vaginal Discharge" },
                    { 20, null, "Joint pain" },
                    { 34, null, "Eye discharge" },
                    { 35, null, "Chest gurgling" },
                    { 36, null, "Epistaxis" },
                    { 28, null, "Vomiting" },
                    { 19, null, "Mass" },
                    { 13, null, "Abdominal pain" },
                    { 17, null, "Itchness" },
                    { 37, null, "Pustules" },
                    { 1, null, "Bleeding" },
                    { 2, null, "Bruise" },
                    { 3, null, "Cough" },
                    { 4, null, "Bites" },
                    { 5, null, "Fever" },
                    { 6, null, "Cold" },
                    { 18, null, "Loss of consciousness" },
                    { 7, null, "Difficulty in swallowing" },
                    { 9, null, "Ear ache/pain" },
                    { 10, null, "Constipation" },
                    { 11, null, "Diarrhea" },
                    { 12, null, "Hair fall" },
                    { 14, null, "Deformity" },
                    { 15, null, "Headache" },
                    { 16, null, "Infected wounds" },
                    { 8, null, "Ear discharge" },
                    { 38, null, "Nasal congestion" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "BrandId", "Description", "GenericId", "InscriptionId" },
                values: new object[,]
                {
                    { 40, 10, "1mg", 7, null },
                    { 190, 80, "100mg/5ml", 16, 23 },
                    { 175, 74, null, 11, 23 },
                    { 173, 73, "2mg/ml", 46, 23 },
                    { 171, 72, "Bot", 48, 23 },
                    { 166, 69, null, 13, 23 },
                    { 152, 60, "100mg/5ml", 1, 23 },
                    { 147, 58, "25mg/1ml", 53, 23 },
                    { 143, 56, "15mg/2.5ml", 4, 23 },
                    { 197, 83, "5mgm/ml", 73, 23 },
                    { 141, 56, "30mg/5ml", 4, 23 },
                    { 124, 47, null, 68, 23 },
                    { 123, 46, null, 13, 23 },
                    { 120, 45, "100mg/5ml", 33, 23 },
                    { 88, 29, "120mg/5ml", 64, 23 },
                    { 81, 27, null, 67, 23 },
                    { 80, 27, "5mg/1mg/5ml", 67, 23 },
                    { 79, 26, null, 76, 23 },
                    { 78, 25, "1.5mg/5ml", 81, 23 },
                    { 132, 51, null, 83, 23 },
                    { 74, 24, "250mg/5ml", 64, 23 },
                    { 206, 87, "3.3g/5ml", 49, 23 },
                    { 212, 91, "250mg/5ml", 64, 23 },
                    { 296, 132, "100mg/5ml", 16, 23 },
                    { 283, 127, null, 36, 23 },
                    { 276, 124, "20mg/5ml", 71, 23 },
                    { 275, 123, "125mg/5ml", 51, 23 },
                    { 270, 120, "1.5mg/5ml", 81, 23 },
                    { 268, 118, "2mg/5ml", 75, 23 },
                    { 262, 115, null, 57, 23 },
                    { 261, 114, "20mg/5ml", 71, 23 },
                    { 211, 91, "120mg/5ml", 64, 23 },
                    { 260, 113, "10mg/5ml", 72, 23 },
                    { 240, 106, null, 13, 23 },
                    { 232, 102, "20mg/5ml", 71, 23 },
                    { 228, 99, "26.7mg/5ml", 82, 23 },
                    { 226, 98, null, 67, 23 },
                    { 220, 95, "250mg/12.5mg", 65, 23 },
                    { 218, 94, null, 13, 23 },
                    { 216, 93, "250mg/5ml", 64, 23 },
                    { 215, 92, "250mg/5ml", 64, 23 },
                    { 242, 107, "125mg/5ml", 23, 23 },
                    { 298, 133, null, 76, 23 },
                    { 68, 22, "1mg/1ml", 10, 23 },
                    { 55, 15, "2mg/5ml", 75, 23 },
                    { 285, 128, "125mg/5ml", 19, 22 },
                    { 284, 128, "250mg/5ml", 19, 22 },
                    { 274, 122, "125mg/5ml", 27, 22 },
                    { 273, 122, "250mg/5ml", 27, 22 },
                    { 272, 122, "250mg/5ml", 27, 22 },
                    { 265, 116, "125mg/5ml", 27, 22 },
                    { 264, 116, "250mg/5ml", 27, 22 },
                    { 263, 116, "250mg/5ml", 27, 22 },
                    { 301, 134, "125mg/5ml", 37, 22 },
                    { 255, 111, "50mg/5ml", 52, 22 },
                    { 246, 108, "250mg/5ml", 27, 22 },
                    { 245, 108, "250mg/5ml", 27, 22 },
                    { 238, 105, "125mg/5ml", 6, 22 },
                    { 237, 105, "250mg/5ml", 6, 22 },
                    { 234, 104, "125mg/5ml", 23, 22 },
                    { 233, 103, "100,000 Iu", 61, 22 },
                    { 225, 97, "250mg/5ml", 28, 22 },
                    { 224, 97, "125mg/5ml", 28, 22 },
                    { 247, 108, "125mg/5ml", 27, 22 },
                    { 56, 16, null, 76, 23 },
                    { 304, 136, "250mg/5ml", 64, 22 },
                    { 315, 138, "400mg/80/5ml", 29, 22 },
                    { 51, 14, null, 76, 23 },
                    { 50, 13, "2mg/5ml", 75, 23 },
                    { 45, 11, "100mg/5ml", 33, 23 },
                    { 31, 7, "15mg/5ml", 4, 23 },
                    { 30, 7, "30mg/3ml", 4, 23 },
                    { 27, 6, "120mg/5ml", 64, 23 },
                    { 22, 4, "5mg/5ml", 22, 23 },
                    { 20, null, "1.5mg/5ml", 81, 23 },
                    { 312, 137, "100mg/5ml", 20, 22 },
                    { 18, 3, "5mg/5ml", 22, 23 },
                    { 346, 151, "200mg/5ml", 8, 22 },
                    { 344, 150, "125mg/5ml", 21, 22 },
                    { 343, 150, "250mg/5ml", 21, 22 },
                    { 342, 149, "200mg/5ml", 8, 22 },
                    { 332, 145, "125mg/5ml", 19, 22 },
                    { 331, 145, "250mg/5ml", 19, 22 },
                    { 329, 144, "250mg/5ml", 17, 22 },
                    { 328, 144, "125mg/5ml", 17, 22 },
                    { 13, 1, "2mg/5ml", 75, 23 },
                    { 305, 136, "120mg/5ml", 64, 23 },
                    { 307, 136, "250mg/5ml", 64, 23 },
                    { 323, 141, null, 76, 23 },
                    { 267, 118, "2mg", 75, 24 },
                    { 210, 90, "50mg", 34, 24 },
                    { 205, 86, "10mg", 32, 24 },
                    { 203, 85, "4mg", 56, 24 },
                    { 202, 85, "10mg", 56, 24 },
                    { 201, 85, "5mg", 56, 24 },
                    { 200, 84, "4mg", 56, 24 },
                    { 199, 84, "10mg", 56, 24 },
                    { 290, 130, "10mg", 56, 24 },
                    { 198, 84, "5mg", 56, 24 },
                    { 195, 83, "25mgm", 73, 24 },
                    { 192, 81, null, 3, 24 },
                    { 188, 78, "250mg", 24, 24 },
                    { 185, 78, "500mg", 24, 24 },
                    { 183, 77, "250mg", 24, 24 },
                    { 181, 77, "500mg", 24, 24 },
                    { 179, 75, "5mg", 56, 24 },
                    { 178, 75, "10mg", 56, 24 },
                    { 196, 83, "50mgm", 73, 24 },
                    { 177, 75, "4mg", 56, 24 },
                    { 291, 130, "5mg", 56, 24 },
                    { 294, 131, "550mg", 59, 24 },
                    { 222, 96, null, 80, 27 },
                    { 208, 88, null, 80, 27 },
                    { 62, 18, "27.5mgm/spray", 38, 27 },
                    { 180, 76, "200mg/40mg/5ml", 29, 26 },
                    { 67, 21, "Cream", 58, 25 },
                    { 352, 89, "30mg", 4, 24 },
                    { 349, 152, "200mg", 2, 24 },
                    { 348, 152, "400mg", 2, 24 },
                    { 292, 130, "4mg", 56, 24 },
                    { 347, 152, "250mg", 8, 24 },
                    { 341, 149, "250mg", 8, 24 },
                    { 340, 149, "500mg", 8, 24 },
                    { 335, 146, "5mg", 50, 24 },
                    { 322, 140, "2mg", 75, 24 },
                    { 309, 136, "325mg", 64, 24 },
                    { 308, 136, "500mg", 64, 24 },
                    { 306, 136, "250mg", 64, 24 },
                    { 295, 131, "275mg", 59, 24 },
                    { 345, 151, "500mg", 8, 24 },
                    { 174, 73, "10mg", 46, 24 },
                    { 172, 73, "25mg", 46, 24 },
                    { 157, 64, "100mg", 41, 24 },
                    { 46, 12, "100mg", 51, 24 },
                    { 44, 11, "100mg", 33, 24 },
                    { 29, 7, "30mg", 4, 24 },
                    { 26, 5, "500mg", 64, 24 },
                    { 25, 5, "325mg", 64, 24 },
                    { 24, 5, "250mg", 64, 24 },
                    { 21, 4, "10mg", 22, 24 },
                    { 12, 1, "2mg", 75, 24 },
                    { 48, 12, "500mg", 51, 24 },
                    { 7, null, "5mg", 71, 24 },
                    { 5, null, "30mg", 71, 24 },
                    { 4, null, "375mg", 28, 24 },
                    { 1, null, "10mg", 22, 24 },
                    { 354, 89, "15mg/5ml", 4, 23 },
                    { 353, 89, "30mg/5ml", 4, 23 },
                    { 338, 147, null, 13, 23 },
                    { 334, 146, "5mg/ml", 50, 23 },
                    { 327, 143, "5mg/5ml", 32, 23 },
                    { 6, null, "20mg", 71, 24 },
                    { 54, 15, "2mg", 75, 24 },
                    { 57, 17, "625mg", 28, 24 },
                    { 63, 19, "500mg", 8, 24 },
                    { 150, 59, "275mg", 59, 24 },
                    { 149, 59, "550mg", 59, 24 },
                    { 146, 58, "500mg", 53, 24 },
                    { 140, 56, "300mg", 4, 24 },
                    { 121, 45, "100mg", 33, 24 },
                    { 114, 40, "125mg", 74, 24 },
                    { 110, 38, "500mg", 24, 24 },
                    { 109, 38, "250mg", 24, 24 },
                    { 106, 36, "500mg", 24, 24 },
                    { 105, 36, "125mg/5ml", 24, 24 },
                    { 87, 29, "325mg", 64, 24 },
                    { 86, 29, "500mg", 64, 24 },
                    { 85, 29, "250mg", 64, 24 },
                    { 76, 24, "325mg", 64, 24 },
                    { 75, 24, "250mg", 64, 24 },
                    { 73, 24, "500mg", 64, 24 },
                    { 69, 22, "10mg", 10, 24 },
                    { 66, 20, "4oomg/80mg", 29, 24 },
                    { 64, 19, "250mg", 8, 24 },
                    { 193, 81, null, 3, 22 },
                    { 187, 78, "125mg/5ml", 24, 22 },
                    { 186, 78, "250mg/5ml", 24, 22 },
                    { 184, 77, "250mg/5ml", 24, 22 },
                    { 92, 30, "50mg/ml", 18, 5 },
                    { 89, 29, "100mg/ml", 64, 5 },
                    { 82, 27, null, 67, 5 },
                    { 77, 24, "100mg/ml", 64, 5 },
                    { 38, 9, "100mg/ml", 6, 5 },
                    { 32, 7, "7.5mg/ml", 4, 5 },
                    { 28, 6, "100ml", 64, 5 },
                    { 23, 5, "2.5mg/ml", 22, 5 },
                    { 96, 31, "100mg/ml", 19, 5 },
                    { 19, 3, "2.5mg/ml", 22, 5 },
                    { 135, 52, null, 55, 4 },
                    { 113, 39, "Tube", 26, 4 },
                    { 339, 148, "250mg", 21, 3 },
                    { 319, 139, "100mg", 20, 3 },
                    { 316, 139, "200mg", 20, 3 },
                    { 313, 137, "200mg", 20, 3 },
                    { 311, 137, "100mg", 20, 3 },
                    { 303, 135, "500mg", 66, 3 },
                    { 17, 2, "100mg/2.5ml", 47, 5 },
                    { 302, 135, "250mg", 66, 3 },
                    { 99, 32, "100mg/ml", 19, 5 },
                    { 122, 46, null, 13, 5 },
                    { 286, 128, "100mg/ml", 19, 5 },
                    { 271, 121, null, 79, 5 },
                    { 241, 106, null, 13, 5 },
                    { 239, 105, "100mg/ml", 6, 5 },
                    { 227, 98, null, 67, 5 },
                    { 219, 94, null, 13, 5 },
                    { 217, 93, "100mg/ml", 64, 5 },
                    { 214, 92, "100ml", 64, 5 },
                    { 100, 33, null, 57, 5 },
                    { 213, 91, "100ml", 64, 5 },
                    { 191, 80, "50mg/ml", 16, 5 },
                    { 170, 71, "100mg/ml", 35, 5 },
                    { 167, 69, null, 13, 5 },
                    { 165, 68, "100mg/ml", 6, 5 },
                    { 142, 56, "7.5mg/5ml", 4, 5 },
                    { 133, 51, null, 83, 5 },
                    { 128, 48, "100mg/2.5ml", 47, 5 },
                    { 125, 47, null, 68, 5 },
                    { 209, 89, "7.5mg/ml", 4, 5 },
                    { 300, 134, "250mg", 37, 3 },
                    { 299, 134, "500mg", 37, 3 },
                    { 256, 111, "250mg", 52, 3 },
                    { 3, null, "250mg", 6, 3 },
                    { 2, null, "500mg", 6, 3 },
                    { 9, null, "40mg/5ml", 43, 2 },
                    { 8, null, "80mg/5ml", 43, 2 },
                    { 249, 109, null, 70, 1 },
                    { 259, 113, null, 72, null },
                    { 148, 58, null, 53, null },
                    { 280, 125, "500mg", 7, null },
                    { 16, 2, "200mg", 47, 3 },
                    { 279, 125, "750mg", 7, null },
                    { 277, 125, "250mg", 7, null },
                    { 253, 110, "250mg", 7, null },
                    { 252, 110, "500mg", 7, null },
                    { 251, 110, "750mg", 7, null },
                    { 250, 110, "1gm", 7, null },
                    { 43, 10, "250mg", 7, null },
                    { 42, 10, "750mg", 7, null },
                    { 41, 10, "500mg", 7, null },
                    { 278, 125, "1gm", 7, null },
                    { 93, 31, "500mg", 19, 3 },
                    { 101, 34, "500mg", 23, 3 },
                    { 103, 34, "250mg", 23, 3 },
                    { 254, 111, "500mg", 52, 3 },
                    { 244, 107, "500mg", 23, 3 },
                    { 243, 107, "250mg", 23, 3 },
                    { 236, 104, "500mg", 23, 3 },
                    { 235, 104, "250mg/5ml", 23, 3 },
                    { 229, 100, "20 Mg", 62, 3 },
                    { 221, 95, "325mg/25mg", 65, 3 },
                    { 194, 82, "200mg", 47, 3 },
                    { 176, 74, null, 11, 3 },
                    { 163, 68, "500mg", 6, 3 },
                    { 162, 67, "1mg/1ml", 31, 3 },
                    { 161, 66, "250mg", 52, 3 },
                    { 160, 66, "500mg", 52, 3 },
                    { 145, 57, "200mg", 47, 3 },
                    { 144, 57, "400mg", 47, 3 },
                    { 139, 55, "300mg", 69, 3 },
                    { 138, 54, "200mg", 60, 3 },
                    { 130, 49, "500mg", 52, 3 },
                    { 129, 49, "250mg", 52, 3 },
                    { 297, 132, "50mg/ml", 16, 5 },
                    { 281, 126, null, 80, 27 },
                    { 310, 136, "100mg/ml", 64, 5 },
                    { 317, 139, "20mg/ml", 20, 5 },
                    { 72, 24, "120mg/5ml", 64, 22 },
                    { 71, 23, "250mg/5ml", 28, 22 },
                    { 70, 23, "125mg/5ml", 28, 22 },
                    { 65, 19, "200mg/5ml", 8, 22 },
                    { 61, 17, "312mg/5ml", 28, 22 },
                    { 60, 17, "228mg/5ml", 28, 22 },
                    { 59, 17, "457mg/5ml", 28, 22 },
                    { 58, 17, "156mg/5ml", 28, 22 },
                    { 84, 29, "250mg/5ml", 64, 22 },
                    { 49, 12, "50mg/ml", 51, 22 },
                    { 39, 9, "125mg/ml", 6, 22 },
                    { 37, 9, "250mg/5ml", 6, 22 },
                    { 36, 8, "312mg/5ml", 28, 22 },
                    { 35, 8, "156mg/5ml", 28, 22 },
                    { 34, 8, "228mg/5ml", 28, 22 },
                    { 33, 8, "457mg/5ml", 28, 22 },
                    { 15, 2, "200mg/5ml", 47, 22 },
                    { 14, 2, "100mg/5ml", 47, 22 },
                    { 47, 12, "20mg/ml", 51, 22 },
                    { 258, 112, "250mg", 64, 21 },
                    { 90, 30, "250mg/5ml", 17, 22 },
                    { 94, 31, "250mg/5ml", 19, 22 },
                    { 182, 77, "125mg/5ml", 24, 22 },
                    { 169, 71, "250mg/5ml", 35, 22 },
                    { 164, 68, "250mg/5ml", 6, 22 },
                    { 158, 64, "16.7mg/5ml", 41, 22 },
                    { 137, 54, "218mg/5ml", 60, 22 },
                    { 127, 48, "100mg/5ml", 47, 22 },
                    { 126, 48, "200mg/5ml", 47, 22 },
                    { 118, 43, "75mg/5ml", 25, 22 },
                    { 91, 30, "125mg/5ml", 17, 22 },
                    { 115, 40, "125mg/5ml", 74, 22 },
                    { 111, 38, "250mg/5ml", 24, 22 },
                    { 108, 37, "125mg/5ml", 24, 22 },
                    { 107, 36, "250mg/5ml", 24, 22 },
                    { 104, 35, "125mg/5ml", 24, 22 },
                    { 102, 34, "125mg/5ml", 23, 22 },
                    { 98, 32, "125mg/5ml", 19, 22 },
                    { 97, 32, "250mg/5ml", 19, 22 },
                    { 95, 31, "125mg/5ml", 19, 22 },
                    { 112, 38, "125mg/5ml", 24, 22 },
                    { 257, 112, "125mg", 64, 21 },
                    { 231, 101, "250mg/5ml", 64, 21 },
                    { 230, 101, "125mg", 64, 21 },
                    { 321, 140, "100mgm/Inhalation", 75, 9 },
                    { 289, 129, "25/50", 78, 9 },
                    { 288, 129, "25/125", 78, 9 },
                    { 287, 129, "25/250", 78, 9 },
                    { 52, 15, "100mgm/Inhalation", 75, 9 },
                    { 134, 52, null, 55, 8 },
                    { 293, 130, "4mg", 56, 7 },
                    { 204, 85, "4mg", 56, 7 },
                    { 189, 79, null, 5, 10 },
                    { 159, 65, null, 44, 6 },
                    { 350, 153, "10mg/ml", 22, 5 },
                    { 337, 147, null, 13, 5 },
                    { 336, 146, "5mg/ml", 50, 5 },
                    { 333, 145, "100mg/ml", 19, 5 },
                    { 330, 144, "50mg/ml", 17, 5 },
                    { 326, 143, "5mg/ml", 32, 5 },
                    { 324, 142, "10mg/ml", 22, 5 },
                    { 318, 139, "100mg/5ml", 20, 5 },
                    { 156, 63, "Tube", 39, 6 },
                    { 207, 88, null, 80, 11 },
                    { 223, 96, null, 80, 11 },
                    { 282, 126, null, 80, 11 },
                    { 351, 153, "1mg/ml", 22, 20 },
                    { 325, 142, "1mg/ml", 22, 20 },
                    { 248, 109, null, 70, 19 },
                    { 168, 70, null, 63, 18 },
                    { 153, 60, "200mg", 1, 18 },
                    { 151, 60, "1000mg", 1, 18 },
                    { 11, null, null, 45, 17 },
                    { 10, null, null, 14, 16 },
                    { 136, 53, null, 9, 15 },
                    { 117, 42, "Tube", 54, 14 },
                    { 155, 62, "Tube", 40, 13 },
                    { 154, 61, "Tube", 42, 13 },
                    { 83, 28, "Sachet", 15, 13 },
                    { 320, 140, "2.5mg/2.5ml", 75, 12 },
                    { 269, 119, null, 77, 12 },
                    { 266, 117, "2.5mg/2.5ml", 75, 12 },
                    { 131, 50, null, 77, 12 },
                    { 116, 41, null, 77, 12 },
                    { 53, 15, "2.5mg/2.5ml", 75, 12 },
                    { 314, 137, "20mg/ml", 20, 5 },
                    { 119, 44, "400mg", 30, 28 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillStatusId",
                table: "Bills",
                column: "BillStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CheckupId",
                table: "Bills",
                column: "CheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PatientId",
                table: "Bills",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCertificates_PatientId",
                table: "MedicalCertificates",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_BrandId",
                table: "Medicines",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_GenericId",
                table: "Medicines",
                column: "GenericId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_InscriptionId",
                table: "Medicines",
                column: "InscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Parent1Id",
                table: "Patients",
                column: "Parent1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Parent2Id",
                table: "Patients",
                column: "Parent2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientStatusId",
                table: "Patients",
                column: "PatientStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinePatients_CheckupId",
                table: "VaccinePatients",
                column: "CheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinePatients_PatientId",
                table: "VaccinePatients",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinePatients_VaccineId",
                table: "VaccinePatients",
                column: "VaccineId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_VaccineTypeId",
                table: "Vaccines",
                column: "VaccineTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Immunizes");

            migrationBuilder.DropTable(
                name: "InPatients");

            migrationBuilder.DropTable(
                name: "Laboratories");

            migrationBuilder.DropTable(
                name: "MedicalCertificates");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Symtoms");

            migrationBuilder.DropTable(
                name: "VaccinePatients");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BillStatuses");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Generics");

            migrationBuilder.DropTable(
                name: "Inscriptions");

            migrationBuilder.DropTable(
                name: "Checkups");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "PatientStatuses");

            migrationBuilder.DropTable(
                name: "VaccineTypes");
        }
    }
}
