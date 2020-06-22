using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlantLovers.DataModel;
using PlantLovers.DataProvider;

namespace PlantLovers.Pages
{
    public class NewFlowerModel : PageModel
    {
        private readonly FlowerDataAccess flowerDataAccess;
        [BindProperty]
        public Flower Flower { get; set; }

        

        public NewFlowerModel(FlowerDataAccess flowerData)
        {
            this.flowerDataAccess = flowerData;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            Flower = flowerDataAccess.Add(Flower);
            flowerDataAccess.Commit();
            return RedirectToPage("./Index",new { flowerId  = Flower.ID});
        }
    }
}