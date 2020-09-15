using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PlantLovers.Controllers;
using PlantLovers.DataAccess;
using PlantLovers.DataModel;
using System.Collections.Generic;
using System.Linq;

namespace PlanLoversUnitTest
{
    [TestClass]
    public class OrderControllerUnitTest
    {
        public  Mock<OrderDataAccess> mockOrderDataAccess = new Mock<OrderDataAccess>();
        private List<Order> MockOrderList = new List<Order>() {
            new Order(2,3,20,"Flora","mar@yahoo.com","265486464","Kolozsvar"),
            new Order(10,2,30,"Tomas","tomas20@gmail.com","56452489541","Kolozsvar"),
            new Order(3,5,32,"Nastasia","pillango20@hotmail.com","5265552","Kolozsvar")
        };
        

        [TestMethod]
        public void TestGetAllOrdersWillReturnAllElementsIfNoParameterSpecified()
        {
            OrderController OrderController = new OrderController(mockOrderDataAccess.Object);
            mockOrderDataAccess.Setup(p => p.GetAll()).Returns(MockOrderList);

            IEnumerable<Order> result = OrderController.GetAll(null, null);
            Assert.AreEqual(3, Enumerable.Count(result));
        }

        [TestMethod]
        public void TestGetAllOrdersWillReturnAllElementsIfEmailSpecified()
        {
            OrderController OrderController = new OrderController(mockOrderDataAccess.Object);
            mockOrderDataAccess.Setup(p => p.GetAll()).Returns(MockOrderList);

            IEnumerable<Order> result = OrderController.GetAll("mar@yahoo.com", null);
            Assert.AreEqual(1, Enumerable.Count(result));
        }

        [TestMethod]
        public void TestGetAllOrdersWillReturnSearchedOrderIfFlowerIdSpecified()
        {
            OrderController OrderController = new OrderController(mockOrderDataAccess.Object);
            mockOrderDataAccess.Setup(p => p.GetAll()).Returns(MockOrderList);

            IEnumerable<Order> result = OrderController.GetAll(null,"3");
            Assert.AreEqual(1, Enumerable.Count(result));
        }

        [TestMethod]
        public void TestGetAllOrdersWillReturnSearchedOrderIfFlowerIdAndEmailSpecified()
        {
            OrderController OrderController = new OrderController(mockOrderDataAccess.Object);
            mockOrderDataAccess.Setup(p => p.GetAll()).Returns(MockOrderList);

            IEnumerable<Order> result = OrderController.GetAll("mar@yahoo.com","3");
            Assert.AreEqual(1, Enumerable.Count(result));
        }
    }
}
