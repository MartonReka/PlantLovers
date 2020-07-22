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

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            User SearchedUser = userDataAccess.GetByUserName(userCredentials.UserName);
            
            if (SearchedUser == null)
            {
                TempData["Message"] = "Username or Password incorrect";
                return RedirectToPage("./LogIn");
            }
            if (SearchedUser.UserName == userCredentials.UserName && SearchedUser.Password == userCredentials.Password)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                TempData["Message"] = "Username or Password incorrect";
                return RedirectToPage("./LogIn");
            }

        }
        /*public IActionResult OnPost()
        {
            return RedirectToPage("./Index");
        }*/
    }
}