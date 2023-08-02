using Microsoft.EntityFrameworkCore;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess
{
    public class SchoolDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I45D279;Initial Catalog=SchoolDBV3;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
           // optionsBuilder.UseSqlServer("server=DESKTOP-I45D279;database=SchoolDB; Integrated security=true");
        }


        public DbSet<School> Schools { get; set; }
        //public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<Students> Students { get; set; }
    }
}
