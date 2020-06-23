using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataModel
{
    public class OrderWithFlowerDetails
    {
        public Order Order { get; set; }
        public Flower Flower { get; set; }

        public OrderWithFlowerDetails(Order order, Flower flower)
        {
            Order = order;
            Flower = flower;
        }
    }
}
