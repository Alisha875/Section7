using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankLogin.Views
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (Username == "abhay" && Password == "Ab@123")
            {
                TempData["User"] = Username;
                return RedirectToPage("/DashBoard");
            }
            else
            {
                return RedirectToPage("");
            }
        }
    }
}
