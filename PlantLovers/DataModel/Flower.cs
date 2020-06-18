using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataModel
{
    public class Flower 
    {
        public int ID { get; set; }
        public string PlantName { get; set; }
        public int PlantPrice { get; set; }
        public string PlantDescription { get; set; }

        public Flower(string PlantName, int PlantPrice, string PlantDescription)
        {
            this.PlantName = PlantName;
            this.PlantPrice = PlantPrice;
            this.PlantDescription = PlantDescription;

        }
    }
}
