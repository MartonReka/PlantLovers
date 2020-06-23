﻿using PlantLovers.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataAccess
{
    public class OrderDataAccess
    {
        private readonly PlantLoversDbContext db;

        public OrderDataAccess(PlantLoversDbContext db)
        {
            this.db = db;
        }

        public Order Add(Order addedOrder)
        {
            db.Add(addedOrder);
            return addedOrder;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
    }
}
