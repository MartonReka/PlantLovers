using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataModel
{
    public class Flower
    {
        public int ID { get; set; }

        [Required, StringLength(80)]
        public string PlantName { get; set; }
        [Required, Range(1, 10000)]
        public int PlantPrice { get; set; }
        [Required, StringLength(1000)]
        public string PlantDescription { get; set; }
        [NotMappedAttribute]
        public IFormFile Picture { get; set; } // for upload

        public byte[] PictureBinary { get; set; } = new byte[0]; // for save in db and display

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
