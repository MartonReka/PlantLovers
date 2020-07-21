using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlantLovers.DataAccess;
using PlantLovers.DataModel;

namespace PlantLovers.Pages
{
    public class LogInModel : PageModel
    {
        private readonly UserDataAccess userDataAccess;
        [BindProperty]
        public UserCredentials userCredentials { get; set; } = new UserCredentials();
        

        public LogInModel(UserDataAccess userDataAccess)
        {
            this.userDataAccess = userDataAccess;
        }

        public void OnPost()
        {
            User SearchedUser = userDataAccess.GetByUserName(userCredentials.UserName);
            if (SearchedUser == null)
            {
               RedirectToPage("./Error");
            }
            if (SearchedUser.UserName == userCredentials.UserName && SearchedUser.Password == userCredentials.Password)
            {
                RedirectToPage("./Index");
            }
            else
            {
                RedirectToPage("./Error");
            }
        }
    }
}