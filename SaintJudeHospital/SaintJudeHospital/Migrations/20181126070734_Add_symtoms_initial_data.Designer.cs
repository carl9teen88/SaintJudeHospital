﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaintJudeHospital.Data.Entity;

namespace SaintJudeHospital.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181126070734_Add_symtoms_initial_data")]
    partial class Add_symtoms_initial_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance");

                    b.Property<int>("BillStatusId");

                    b.Property<int>("CheckupId");

                    b.Property<decimal>("ConsultationFee");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<decimal>("EarPiercingFee");

                    b.Property<decimal>("FollowUpFee");

                    b.Property<decimal>("NebulizationFee");

                    b.Property<decimal>("PPDFee");

                    b.Property<int>("PatientId");

                    b.Property<string>("PayProcess");

                    b.Property<decimal>("TotalPayment");

                    b.Property<string>("VaccineInfo");

                    b.HasKey("Id");

                    b.HasIndex("BillStatusId");

                    b.HasIndex("CheckupId");

                    b.HasIndex("PatientId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.BillStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BillStatuses");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Checkup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Assessment");

                    b.Property<string>("CivilStatus");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Diagnosis");

                    b.Property<string>("Gender");

                    b.Property<string>("HeadCircum");

                    b.Property<string>("Height");

                    b.Property<string>("Name");

                    b.Property<DateTime>("NextVisitDate");

                    b.Property<string>("Objective");

                    b.Property<string>("Prescription");

                    b.Property<string>("Subjective");

                    b.Property<string>("Temperature");

                    b.Property<string>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Checkups");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Immunize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Immunizes");

                    b.HasData(
                        new { Id = 1, Amount = 3000m, Name = "HEXA" },
                        new { Id = 2, Amount = 3200m, Name = "PCV 10" },
                        new { Id = 3, Amount = 750m, Name = "MEASLES" },
                        new { Id = 4, Amount = 1300m, Name = "HIB" },
                        new { Id = 5, Amount = 4000m, Name = "MENINGO" },
                        new { Id = 6, Amount = 1300m, Name = "TYPHOID" },
                        new { Id = 7, Amount = 1800m, Name = "HEP A" },
                        new { Id = 8, Amount = 700m, Name = "HEP B" },
                        new { Id = 9, Amount = 1600m, Name = "TETRAXIM" },
                        new { Id = 10, Amount = 1200m, Name = "MMR" },
                        new { Id = 11, Amount = 2200m, Name = "CHICKEN POX" },
                        new { Id = 12, Amount = 2500m, Name = "PENTA" },
                        new { Id = 13, Amount = 900m, Name = "BCG-1" },
                        new { Id = 14, Amount = 3000m, Name = "MMR-V" },
                        new { Id = 15, Amount = 1700m, Name = "PNEUMO-23" },
                        new { Id = 16, Amount = 1700m, Name = "RABIES" },
                        new { Id = 17, Amount = 3000m, Name = "ROTARIX" },
                        new { Id = 18, Amount = 2200m, Name = "ROTATEQ" },
                        new { Id = 19, Amount = 1000m, Name = "FLU" },
                        new { Id = 20, Amount = 4000m, Name = "PCV" },
                        new { Id = 21, Amount = 0m, Name = "BCG-2" }
                    );
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.InPatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("InPatients");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Laboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Laboratories");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.MedicalCertificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Diagnosis");

                    b.Property<string>("Operation");

                    b.Property<int>("PatientId");

                    b.Property<string>("Remarks");

                    b.Property<string>("Requestor");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicalCertificates");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Description");

                    b.Property<string>("GenericName");

                    b.Property<string>("Inscription");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Occupation");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<string>("CivilStatus");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int?>("Parent1Id");

                    b.Property<int?>("Parent2Id");

                    b.Property<int?>("ParentId1");

                    b.Property<int?>("ParentId2");

                    b.Property<int>("PatientStatusId");

                    b.HasKey("Id");

                    b.HasIndex("Parent1Id");

                    b.HasIndex("Parent2Id");

                    b.HasIndex("PatientStatusId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.PatientStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PatientStatuses");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Role", b =>
                {
                    b.Property<int>("RoleId");

                    b.Property<string>("Name");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new { RoleId = 1, Name = "Administrator" },
                        new { RoleId = 2, Name = "StandardUser" }
                    );
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Symtom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Symtoms");

                    b.HasData(
                        new { Id = 1, Name = "Bleeding" },
                        new { Id = 2, Name = "Bruise" },
                        new { Id = 3, Name = "Cough" },
                        new { Id = 4, Name = "Bites" },
                        new { Id = 5, Name = "Fever" },
                        new { Id = 6, Name = "Cold" },
                        new { Id = 7, Name = "Difficulty in swallowing" },
                        new { Id = 8, Name = "Ear discharge" },
                        new { Id = 9, Name = "Ear ache/pain" },
                        new { Id = 10, Name = "Constipation" },
                        new { Id = 11, Name = "Diarrhea" },
                        new { Id = 12, Name = "Hair fall" },
                        new { Id = 13, Name = "Abdominal pain" },
                        new { Id = 14, Name = "Deformity" },
                        new { Id = 15, Name = "Headache" },
                        new { Id = 16, Name = "Infected wounds" },
                        new { Id = 17, Name = "Itchness" },
                        new { Id = 18, Name = "Loss of consciousness" },
                        new { Id = 19, Name = "Mass" },
                        new { Id = 20, Name = "Joint pain" },
                        new { Id = 21, Name = "Muscle pain" },
                        new { Id = 22, Name = "Skin lesions" },
                        new { Id = 23, Name = "Trauma" },
                        new { Id = 24, Name = "Pain urination" },
                        new { Id = 25, Name = "Rushes" },
                        new { Id = 26, Name = "Less appetite" },
                        new { Id = 27, Name = "LBM" },
                        new { Id = 28, Name = "Vomiting" },
                        new { Id = 29, Name = "Dysuria" },
                        new { Id = 30, Name = "Rashes" },
                        new { Id = 31, Name = "Dysphagia" },
                        new { Id = 32, Name = "Vaginal Discharge" },
                        new { Id = 33, Name = "Urticarial rash" },
                        new { Id = 34, Name = "Eye discharge" },
                        new { Id = 35, Name = "Chest gurgling" },
                        new { Id = 36, Name = "Epistaxis" },
                        new { Id = 37, Name = "Pustules" },
                        new { Id = 38, Name = "Nasal congestion" }
                    );
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("RoleId");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new { UserId = 1, FirstName = "Carl", LastName = "Tanilon", Password = "1234", RoleId = 1, Username = "carl" }
                    );
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Booster");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Dose");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<int>("VaccineTypeId");

                    b.HasKey("Id");

                    b.HasIndex("VaccineTypeId");

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.VaccinePatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CheckupId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("PatientId");

                    b.Property<int>("VaccineId");

                    b.HasKey("Id");

                    b.HasIndex("CheckupId");

                    b.HasIndex("PatientId");

                    b.HasIndex("VaccineId");

                    b.ToTable("VaccinePatients");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.VaccineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("VaccineTypes");
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Bill", b =>
                {
                    b.HasOne("SaintJudeHospital.Data.Entity.BillStatus", "BillStatus")
                        .WithMany()
                        .HasForeignKey("BillStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaintJudeHospital.Data.Entity.Checkup", "Checkup")
                        .WithMany()
                        .HasForeignKey("CheckupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaintJudeHospital.Data.Entity.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.MedicalCertificate", b =>
                {
                    b.HasOne("SaintJudeHospital.Data.Entity.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Medicine", b =>
                {
                    b.HasOne("SaintJudeHospital.Data.Entity.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Patient", b =>
                {
                    b.HasOne("SaintJudeHospital.Data.Entity.Parent", "Parent1")
                        .WithMany()
                        .HasForeignKey("Parent1Id");

                    b.HasOne("SaintJudeHospital.Data.Entity.Parent", "Parent2")
                        .WithMany()
                        .HasForeignKey("Parent2Id");

                    b.HasOne("SaintJudeHospital.Data.Entity.PatientStatus", "PatientStatus")
                        .WithMany()
                        .HasForeignKey("PatientStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.User", b =>
                {
                    b.HasOne("SaintJudeHospital.Data.Entity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.Vaccine", b =>
                {
                    b.HasOne("SaintJudeHospital.Data.Entity.VaccineType", "VaccineType")
                        .WithMany()
                        .HasForeignKey("VaccineTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaintJudeHospital.Data.Entity.VaccinePatient", b =>
                {
                    b.HasOne("SaintJudeHospital.Data.Entity.Checkup", "Chekup")
                        .WithMany()
                        .HasForeignKey("CheckupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaintJudeHospital.Data.Entity.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaintJudeHospital.Data.Entity.Vaccine", "Vaccine")
                        .WithMany()
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
