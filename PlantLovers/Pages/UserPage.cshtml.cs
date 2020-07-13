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
    public class UserPageModel : PageModel
    {
        private readonly UserDataAccess userDataAccess;
        [BindProperty]
        public User User { get; set; } = new User();

        public UserPageModel(UserDataAccess userDataAccess)
        {
            this.userDataAccess = userDataAccess;
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            User = userDataAccess.Add(User);
            userDataAccess.Commit();
            return RedirectToPage("./UserPage");
        }
    }
}