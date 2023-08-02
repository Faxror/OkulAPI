﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OkulYönetimAPI.DataAccess;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    [DbContext(typeof(SchoolDBContext))]
    partial class SchoolDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OkulYönetimAPI.Entity.School", b =>
                {
                    b.Property<int>("ıd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ıd"));

                    b.Property<string>("schoolname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ıd");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("OkulYönetimAPI.Entity.Students", b =>
                {
                    b.Property<int>("ıd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ıd"));

                    b.Property<string>("studentname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentschool")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentsurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ıd");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
