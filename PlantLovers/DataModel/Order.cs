using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataModel
{
    public class Order
    {
        public int ID { get; set; }

        public int FlowerID { get; set; }
        [Required, Range(1, 100)]
        public int Amount { get; set; }
        [Required, StringLength(1000)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string Telefon { get; set; }
        [Required, StringLength(1000)]
        public string Adress { get; set; }

        public Order()
            {
        }

        public Order(int iD, int flowerID, int amount, string name, string email, string telefon, string adress)
        {
            ID = iD;
            FlowerID = flowerID;
            Amount = amount;
            Name = name;
            Email = email;
            Telefon = telefon;
            Adress = adress;
        }
    }
}
