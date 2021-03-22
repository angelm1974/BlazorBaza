﻿// <auto-generated />
using System;
using BazaBlazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BazaBlazor.Migrations
{
    [DbContext(typeof(DataAppContext))]
    partial class DataAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("BazaBlazor.Data.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PavilionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Species")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PavilionId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("BazaBlazor.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BazaBlazor.Data.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("BazaBlazor.Data.Pavilion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pavilions");
                });

            modelBuilder.Entity("BazaBlazor.Data.Animal", b =>
                {
                    b.HasOne("BazaBlazor.Data.Employee", "Employee")
                        .WithMany("Animals")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BazaBlazor.Data.Pavilion", "Pavilion")
                        .WithMany("Animals")
                        .HasForeignKey("PavilionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Pavilion");
                });

            modelBuilder.Entity("BazaBlazor.Data.Food", b =>
                {
                    b.HasOne("BazaBlazor.Data.Animal", "Animal")
                        .WithMany("Foods")
                        .HasForeignKey("AnimalId");

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("BazaBlazor.Data.Animal", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("BazaBlazor.Data.Employee", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("BazaBlazor.Data.Pavilion", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
