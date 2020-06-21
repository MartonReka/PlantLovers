using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlantLovers.DataModel;
using PlantLovers.DataProvider;

namespace PlantLovers.Pages
{
    public class DetailModel : PageModel
    {
        private readonly FlowerDataAccess flowerDataAccess;
        public Flower Flower { get; set; }

        public DetailModel(FlowerDataAccess flowerData)
        {
            this.flowerDataAccess = flowerData;
        }

        public void OnGet(int flowerId)
        {
            Flower = flowerDataAccess.GetById(flowerId);
        }
    }
}