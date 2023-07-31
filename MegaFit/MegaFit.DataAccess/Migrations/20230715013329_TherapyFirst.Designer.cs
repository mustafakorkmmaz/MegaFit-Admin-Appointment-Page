﻿// <auto-generated />
using System;
using MegaFit.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    [DbContext(typeof(MegaContext))]
    [Migration("20230715013329_TherapyFirst")]
    partial class TherapyFirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MegaFit.EntityLayer.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 0,
                            CustomerAddress = "Uskudar",
                            EmailAddress = "mustafakorkmmaz@gmail.com",
                            FirstName = "Mustafa",
                            Height = 0,
                            IdentityNumber = "11102613645",
                            LastName = "Korkmaz",
                            PhoneNumber = "05343494123",
                            Weight = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 0,
                            CustomerAddress = "Kartal",
                            EmailAddress = "mesutrizatunur@gmail.com",
                            FirstName = "Mesut Rıza",
                            Height = 0,
                            IdentityNumber = "313569752136",
                            LastName = "Tunur",
                            PhoneNumber = "05343494122",
                            Weight = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 0,
                            CustomerAddress = "Maltepe",
                            EmailAddress = "yunusakbulut@gmail.com",
                            FirstName = "Yunus",
                            Height = 0,
                            IdentityNumber = "22269813645",
                            LastName = "Akbulut",
                            PhoneNumber = "05343494121",
                            Weight = 0
                        });
                });

            modelBuilder.Entity("MegaFit.EntityLayer.Entities.CustomerAssessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Evaluation")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisitId");

                    b.ToTable("CustomerAssessment", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Evaluation = "Deneme",
                            VisitId = 1
                        },
                        new
                        {
                            Id = 2,
                            Evaluation = "Deneme",
                            VisitId = 2
                        },
                        new
                        {
                            Id = 3,
                            Evaluation = "Deneme",
                            VisitId = 3
                        });
                });

            modelBuilder.Entity("MegaFit.EntityLayer.Entities.CustomerVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Complaint")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsSick")
                        .HasColumnType("bit");

                    b.Property<string>("SicknessList")
                        .HasColumnType("varchar(250)");

                    b.Property<bool>("UsingDrugs")
                        .HasColumnType("bit");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2(0)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerVisit", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Complaint = "Şikayet",
                            CustomerId = 1,
                            IsSick = true,
                            UsingDrugs = true,
                            VisitDate = new DateTime(2023, 7, 15, 4, 33, 29, 19, DateTimeKind.Local).AddTicks(4155)
                        },
                        new
                        {
                            Id = 2,
                            Complaint = "Test",
                            CustomerId = 2,
                            IsSick = false,
                            UsingDrugs = false,
                            VisitDate = new DateTime(2023, 7, 15, 4, 33, 29, 20, DateTimeKind.Local).AddTicks(8058)
                        },
                        new
                        {
                            Id = 3,
                            Complaint = "Deneme",
                            CustomerId = 3,
                            IsSick = true,
                            UsingDrugs = false,
                            VisitDate = new DateTime(2023, 7, 15, 4, 33, 29, 20, DateTimeKind.Local).AddTicks(8066)
                        });
                });

            modelBuilder.Entity("MegaFit.EntityLayer.Entities.Therapy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Therapy", (string)null);
                });

            modelBuilder.Entity("MegaFit.EntityLayer.Entities.CustomerAssessment", b =>
                {
                    b.HasOne("MegaFit.EntityLayer.Entities.CustomerVisit", "CustomerVisit")
                        .WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CustomerVisit");
                });

            modelBuilder.Entity("MegaFit.EntityLayer.Entities.CustomerVisit", b =>
                {
                    b.HasOne("MegaFit.EntityLayer.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
