
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Options;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace OkulYönetimAPI.DataAccess
{
    public class SchoolDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // kasadaki sql server = optionsBuilder.UseSqlServer("Data Source=DESKTOP-N4SK79N;Initial Catalog=SchoolDBV4;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-I45D279;Initial Catalog=SchoolDBV5;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            // optionsBuilder.UseSqlServer("server=DESKTOP-I45D279;database=SchoolDB; Integrated security=true");
            //optionsBuilder.("server=Local;database=OKULAPİ; Integrated security=true; TrustServerCertificate=True");

            optionsBuilder.UseNpgsql("Server=localhost;Port=5434;Database=SchoolAdministratorV1;User Id=postgres;Password=Asdfgh7890;");
        }
   

        public DbSet<Schools> Schools { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Students> Students { get; set; }
    }
}
