using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataModel
{
    public class Flower 
    {
        public int ID { get; set; }

        [Required, StringLength(80)]
        public string PlantName { get; set; }
        [Required, Range(1,10000)]
        public int PlantPrice { get; set; }
        [Required, StringLength(1000)]
        public string PlantDescription { get; set; }

        public Flower()
        {

        }
        public Flower(string PlantName, int PlantPrice, string PlantDescription)
        {
            this.PlantName = PlantName;
            this.PlantPrice = PlantPrice;
            this.PlantDescription = PlantDescription;

        }
        
    }
}
