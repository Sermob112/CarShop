using CarShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Place> Places { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>().HasData(
                    new Place { id = 1, price = 500 },
                    new Place { id = 2, price = 500 },
                    new Place { id = 3, price = 500 },
                     new Place { id = 4, price = 500 },
                      new Place { id = 5, price = 1000 },
                       new Place{ id = 6, price = 1000 },
                        new Place { id = 7, price = 1000 },
                         new Place { id = 8, price = 1500 },
                          new Place { id = 9, price = 1500 },
                              new Place { id = 10, price = 1500 }
            );
        }

    }
}
