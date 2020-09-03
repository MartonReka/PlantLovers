using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PlantLovers.DataModel;
using PlantLovers.DataProvider;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlantLovers.Properties
{
    [Route("api/flowers")]
    public class FlowerController : Controller
    {
        //public Flower Yukka = new Flower("Jukka", 30, "napos helyet szereti");
        //public Flower Gumifa = new Flower("Gumifa", 30, "szaraz, arnyekos helyet szereti");
        //public Flower Orchidea = new Flower("Orchidea", 30, "felig napos helyet szereti");

        public FlowerDataAccess FlowerDataAccess { get; }

        public FlowerController(FlowerDataAccess flowerDataAccess)
        {
            FlowerDataAccess = flowerDataAccess;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Flower> GetAll( [FromQuery(Name = "flowerName")]string PlantName)
        {
            if (PlantName == null)
            {
                return FlowerDataAccess.GetAll();
            }
            else
            {
                var query = from f in FlowerDataAccess.GetAll()
                            where f.PlantName.Contains(PlantName)
                            select f;
                return query;
            }
        }

        // GET: api/flower/byName>
        //[HttpGet]
        //[Route(" byName ")]
        //public IEnumerable<Flower> GetAllByName([FromQuery(Name = "flowerName ")]string PlantName)
        //{

        //    return from flower in FlowerDataAccess.GetAll()
        //           where flower.PlantName.StartsWith(PlantName)
        //           select flower;
                    
        //}

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Flower GetById(int ID)
        {
            return FlowerDataAccess.GetById(ID);
                
        }
        // POST api/<controller>
        [HttpPost]
        public Flower CreateNewFlower ([FromBody]Flower flowerFromPostBody)
        {
            Flower NewFlower = FlowerDataAccess.Add(flowerFromPostBody);
            FlowerDataAccess.Commit();
            return NewFlower;
            
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Flower Put(int id, [FromBody]Flower updatedFlowerFromBody)
        {
            Flower FlowerFromDb = FlowerDataAccess.GetById(id);
            FlowerFromDb.PlantName = updatedFlowerFromBody.PlantName;
            FlowerFromDb.PlantPrice = updatedFlowerFromBody.PlantPrice;
            FlowerFromDb.PlantDescription = updatedFlowerFromBody.PlantDescription;

            Flower Updatedflower = FlowerDataAccess.Update(FlowerFromDb);
            FlowerDataAccess.Commit();
            return Updatedflower;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FlowerDataAccess.Delete(id);
            FlowerDataAccess.Commit();
            //System.Diagnostics.Debug.WriteLine("Kitoroltem az id" + id);
        }
      

    }
}
