using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantLovers.DataAccess;
using PlantLovers.DataModel;

namespace PlantLovers.Pages
{
    public class UserPageModel : PageModel
    {
        private readonly UserDataAccess userDataAccess;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]
        public User RegisteredUser { get; set; } = new User();
        public IEnumerable<SelectListItem> UserTypes { get; set; }

        public UserPageModel(UserDataAccess userDataAccess, IHtmlHelper htmlHelper)
        {
            this.userDataAccess = userDataAccess;
            this.htmlHelper = htmlHelper;

        }

        public IActionResult OnGet()
        {
            UserTypes = htmlHelper.GetEnumSelectList<UserType>();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            User VerifiedUser = userDataAccess.GetByUserName(RegisteredUser.UserName);
            if(VerifiedUser != null)
            {
               TempData["Message"] = $"Username:{RegisteredUser.UserName} is taken";
               return RedirectToPage("./UserPage");
            }
            RegisteredUser = userDataAccess.Add(RegisteredUser);
            userDataAccess.Commit();
            return RedirectToPage("./UserPage");
        }
    }
}