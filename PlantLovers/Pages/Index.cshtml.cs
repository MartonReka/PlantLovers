using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlantLovers.DataModel;

namespace PlantLovers.Pages
{
    public class IndexModel : PageModel
    {
        public List<Flower> FlowersList = new List<Flower>();

        public void OnGet()
        {
            FlowersList.Add(new Flower("Csihany", 1, "napos-esos helyet szereti"));
            FlowersList.Add(new Flower("Margaretta", 10, "Mezon terem"));
        }
    }
}
