using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlantLovers.DataAccess;
using PlantLovers.DataModel;
using PlantLovers.DataProvider;

namespace PlantLovers.Pages
{
    public class OrderListModel : PageModel
    {
        private readonly FlowerDataAccess flowerDataAccess;
        private readonly OrderDataAccess orderDataAccess;

        public IEnumerable<Order> OrderList = new List<Order>();

        public OrderListModel(FlowerDataAccess flowerData, OrderDataAccess orderData)
        {
            this.flowerDataAccess = flowerData;
            this.orderDataAccess = orderData;
        }
        
        public void OnGet()
        {
            OrderList = orderDataAccess.GetAll();

        }
       
    }
}