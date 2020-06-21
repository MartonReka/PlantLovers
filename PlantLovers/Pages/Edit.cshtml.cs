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
    public class EditModel : PageModel
    {
        private readonly FlowerDataAccess flowerDataAccess;
        public Flower Flower { get; set; }

        public EditModel(FlowerDataAccess flowerData)
        {
            this.flowerDataAccess = flowerData;
        }

        public void OnGet(int flowerId)
        {
            Flower = flowerDataAccess.GetById(flowerId);
        }

         /*public IActionResult OnPost()
        {

        }*/
    }
}