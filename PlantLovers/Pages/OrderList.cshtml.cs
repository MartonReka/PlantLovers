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

        public List<OrderWithFlowerDetails> OrderListWithFlowerDetails = new List<OrderWithFlowerDetails>();

        public OrderListModel(FlowerDataAccess flowerData, OrderDataAccess orderData)
        {
            this.flowerDataAccess = flowerData;
            this.orderDataAccess = orderData;
        }
        public void OnGet()
        {
            IEnumerable<Order> OrderList = orderDataAccess.GetAll();

            foreach (var Order in OrderList)
            {
               Flower OrderFlower = flowerDataAccess.GetById(Order.FlowerID);
               OrderListWithFlowerDetails.Add(new OrderWithFlowerDetails(Order,OrderFlower));
            }
        }
    }
}