using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantLovers.DataAccess;
using PlantLovers.DataModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlantLovers.Controllers
{
    [Route("api/orders")]
    public class OrderController : Controller
    {
        public OrderDataAccess OrderDataAccess { get; }

        public OrderController(OrderDataAccess orderDataAccess)
        {
            OrderDataAccess = orderDataAccess;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Order> GetAll([FromQuery(Name = "email")]string email,
                                         [FromQuery(Name = "flowerid")]string flowerid)
        {
            if (email == null && flowerid == null )
            {
                return OrderDataAccess.GetAll();
            }
            

            if (flowerid != null && email == null)
            {
                var query = from f in OrderDataAccess.GetAll()
                            where f.FlowerID.ToString().Equals(flowerid)
                            select f;
                return query;

            }

            if (flowerid == null && email != null)
            {
                var query = from f in OrderDataAccess.GetAll()
                            where f.Email.Equals(email)
                            select f;
                return query;

            }
            if (flowerid != null && email != null)
            {
                var query = from f in OrderDataAccess.GetAll()
                            where f.FlowerID.ToString().Equals(flowerid)
                            where f.Email.Equals(email)
                            select f;
                return query;

            }

            return null;

        }

        // GET api/<controller>/5
        [HttpPost]
        public Order CreateNewOrder([FromBody]Order ordeFromBody)
        {
            Order NewOrder = OrderDataAccess.Add(ordeFromBody);
            OrderDataAccess.Commit();
            return NewOrder;
        }

    }
}
