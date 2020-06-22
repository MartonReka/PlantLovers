using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using PlantLovers.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
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

        public Flower Delete (int id)
        {
            var flower = GetById(id);
            if(flower != null)
            {
                db.Flowers.Remove(flower);
            }
            return flower;

        }

        public Flower Update(Flower updatedFlower)
        {
            CopyToBinary(updatedFlower);
            var entity = db.Flowers.Attach(updatedFlower);
            entity.State = EntityState.Modified;
            return updatedFlower;
        }  

        public Flower Add(Flower addedFlower)
        {
            CopyToBinary(addedFlower);
            db.Add(addedFlower);
            return addedFlower;
        }

        public int Commit()
        {
            return db.SaveChanges();

        }

        public IEnumerable<Flower>GetFlowersByName(string name)
        {
            var query = from r in db.Flowers
                        where r.PlantName.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.PlantName
                        select r;

            return query;
        }

        private void CopyToBinary(Flower flower)
        {
            using (var ms = new MemoryStream())
            {
                flower.Picture.CopyToAsync(ms);
                flower.PictureBinary = ms.ToArray();
                
            }
        }

    }
}
