﻿using PlantLovers.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataAccess
{
    public class UserDataAccess
    {
        private readonly PlantLoversDbContext db;

        public UserDataAccess(PlantLoversDbContext db)
        {
            this.db = db;
        }

        public User Add(User addedOrder)
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
