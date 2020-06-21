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
    public class IndexModel : PageModel
    {
        private readonly FlowerDataAccess flowerDataAccess;
        public IEnumerable<Flower> FlowersList = new List<Flower>();

        public IndexModel(FlowerDataAccess flowerData)
        {
            this.flowerDataAccess = flowerData;
        }

        public void OnGet()
        {
            FlowersList = flowerDataAccess.GetAll();

        }
    }
}
