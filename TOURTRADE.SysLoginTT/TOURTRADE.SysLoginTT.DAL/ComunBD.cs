using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TOURTRADE.SysLoginTT.EN;
namespace TOURTRADE.SysLoginTT.DAL
{
    


        public class ComunDB : DbContext
        {
            public DbSet<Role> Roles { get; set; }
            public DbSet<User> Users { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NFDMETJ;Initial Catalog=TOURTRADEBD;Integrated Security=True;Trust Server Certificate=True");
            }

        }
    }

