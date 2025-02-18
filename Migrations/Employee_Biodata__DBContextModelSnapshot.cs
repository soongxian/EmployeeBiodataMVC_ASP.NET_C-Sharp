﻿// <auto-generated />
using System;
using EmployeeBiodataMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeBiodataMVC.Migrations
{
    [DbContext(typeof(Employee_Biodata__DBContext))]
    partial class Employee_Biodata__DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeBiodataMVC.Models.Employee_Biodata", b =>
                {
                    b.Property<string>("employee_no")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<DateTime>("birth_date")
                        .HasColumnType("DATETIME");

                    b.Property<string>("employee_name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("employee_no");

                    b.ToTable("Employee_Biodata");
                });
#pragma warning restore 612, 618
        }
    }
}
