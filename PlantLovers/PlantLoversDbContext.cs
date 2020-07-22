using Microsoft.EntityFrameworkCore;
using PlantLovers.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers
{
    public class PlantLoversDbContext : DbContext
    {
        public PlantLoversDbContext(DbContextOptions<PlantLoversDbContext> options)
               :base(options)
        {

        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
        }
    }


}
