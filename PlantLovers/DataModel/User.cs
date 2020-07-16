using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataModel
{
    public class User
    {
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(15)]
        public string Telefon { get; set; }
        [Required, StringLength(100)]
        public string UserName { get; set; }
        [Required, StringLength(10)]
        public string Password { get; set; }
       
        public UserType UserType { get; set; }

        public User()
        {

        }

        /*public User(string Name, string Email, string Telefon, string UserName, string Password, string UserType)
        {
            this.Name = Name;
            this.Email = Email;
            this.Telefon = Telefon;
            this.UserName = UserName;
            this.Password = Password;
            this.UserType = UserType;

        }*/
    }
}
