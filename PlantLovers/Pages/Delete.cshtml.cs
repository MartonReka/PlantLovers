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
    public class DeleteModel : PageModel
    {
        private readonly FlowerDataAccess flowerDataAccess;

        public Flower Flower { get; set; }

        public DeleteModel(FlowerDataAccess flowerData)
        {
            this.flowerDataAccess = flowerData;
        } 
        public IActionResult OnGet(int flowerId)
        {
            Flower = flowerDataAccess.GetById(flowerId);
            if (Flower == null)
            {
                return RedirectToPage("./Index");
            }
            return Page();
        }

        public IActionResult OnPost(int flowerId)
        {
            var flower = flowerDataAccess.Delete(flowerId);
            flowerDataAccess.Commit();
            if (Flower == null)
            {
                return RedirectToPage("./Index");
            }
            TempData["Message"] = $"{flower.PlantName} deleted";
            return RedirectToPage("./Index");

        }
    }
}