using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurs.Models
{ 
        public class ApplicationContext : IdentityDbContext<User>
        {
        public DbSet<Letter> Letters { get; set; }
        public DbSet<Kontragent> Kontragents { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tema> Temas { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
               // Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
    }

