using PlantLovers.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataProvider
{
    // ctor + dupla Tab
    public class FlowerDataAccess
    {
        private readonly PlantLoversDbContext db;

        public FlowerDataAccess(PlantLoversDbContext db)
        {
            this.db = db;
        }

       public IEnumerable<Flower> GetAll()
        {
            var query = from f in db.Flowers
                        orderby f.PlantName
                        select f;

            return query;
                   
       }


        public Flower GetById( int id)
        {
            return db.Flowers.Find(id);
        }

        /*public Flower Delete (int id)
        {
            var flower = flower.
        }*/

        public Flower Update(Flower updatedFlower)
        {

            return updatedFlower;
        }  
    }
}
