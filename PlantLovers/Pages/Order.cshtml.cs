using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantLovers;
using PlantLovers.DataAccess;
using PlantLovers.DataModel;
using PlantLovers.DataProvider;

namespace PlantLovers.Pages
{
    public class OrderModel : PageModel
    {
        private readonly FlowerDataAccess flowerDataAccess;
        private readonly OrderDataAccess orderDataAccess;
        public Flower Flower { get; set; }


        [BindProperty]
        public Order Order { get; set; }

        public OrderModel(FlowerDataAccess flowerData, OrderDataAccess orderData)
        {
            this.flowerDataAccess = flowerData;
            this.orderDataAccess = orderData;
        }


        public void OnGet(int flowerId)
        {
            Flower = flowerDataAccess.GetById(flowerId);
           
        }

        public IActionResult OnPost()
        {
            Order = orderDataAccess.Add(Order);
            orderDataAccess.Commit();
            return RedirectToPage("./Index");

        }


       
    }
}