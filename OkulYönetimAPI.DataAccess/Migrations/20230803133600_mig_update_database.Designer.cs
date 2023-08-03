﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OkulYönetimAPI.DataAccess;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    [DbContext(typeof(SchoolDBContext))]
    [Migration("20230803133600_mig_update_database")]
    partial class mig_update_database
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OkulYönetimAPI.Entity.Schools", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("schooladress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("schoolphone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("OkulYönetimAPI.Entity.Students", b =>
                {
                    b.Property<int>("ıd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ıd"));

                    b.Property<string>("aappointedteachers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("OkulYönetimAPI.Entity.Teachers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("teacheralan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teachername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teachernumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teachersurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
