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

    }
}
