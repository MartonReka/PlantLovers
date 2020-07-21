using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantLovers.DataModel
{
    public class UserCredentials
    {
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string UserName { get; set; }
        [Required, StringLength(10)]
        public string Password { get; set; }
    }
}
