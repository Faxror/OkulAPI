﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OkulYönetimAPI.DataAccess;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    [DbContext(typeof(SchoolDBContext))]
    [Migration("20230926100525_mig_postgresql_update_3")]
    partial class mig_postgresql_update_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OkulYönetimAPI.Entity.HomeworkandExams", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("examnotefour")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("examnotesone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("examnotethree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("examnotetwo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("homeworks")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("HomeworkandExams");
                });

            modelBuilder.Entity("OkulYönetimAPI.Entity.Lessons", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("lessons")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("OkulYönetimAPI.Entity.Schools", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("schooladress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("schoolname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("schoolphone")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("OkulYönetimAPI.Entity.Students", b =>
                {
                    b.Property<int>("ıd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ıd"));

                    b.Property<int>("IdentıtyNumber")
                        .HasColumnType("integer");

                    b.Property<int>("StudentsPassword")
                        .HasColumnType("integer");

                    b.Property<string>("aappointedteachers")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("examnotesone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("examnotestfour")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("examnotesthree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("examnotestwo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("homeworks")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("studentname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("studentnumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("studentschool")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("studentsclassnumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("studentslevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("studentsurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ıd");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("OkulYönetimAPI.Entity.Teachers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("teacheralan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("teachername")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("teachernumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("teacherpermissions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("teachersurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
