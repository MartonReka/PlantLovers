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
        public DbSet<Flower>Flowers { get; set; }

    }
}
