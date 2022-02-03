using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPC_Authentication.Model;

namespace RPC_Authentication
{
    public class User_FormModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Index");
            
        }
    }
}
