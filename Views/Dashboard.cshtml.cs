using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankLogin.Views
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
            ViewData["User"] = TempData["User"];
        }

        public IActionResult OnPost()
        {

            return RedirectToPage("/Login");
        }
    }
}
