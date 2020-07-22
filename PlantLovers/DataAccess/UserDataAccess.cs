using PlantLovers.DataModel;
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

        public User Add(User addedUser)
        {
            db.Add(addedUser);
            return addedUser;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public User GetByUserName(string UserName)
        {
            var UserByUserName = (from r in db.Users
                                  where r.UserName == UserName
                                  orderby r.UserName
                                  select r).SingleOrDefault();
            return UserByUserName;
        }


    }
}
