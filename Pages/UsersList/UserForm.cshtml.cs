using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPC_Authentication.Models;

namespace RPC_Authentication.Pages.UsersList
{
    public class UserFormModel : PageModel
    {
        [BindProperty]
        public UserRPC UserRPC { get; set; }
        public void OnGet()
        {
        }
    }
}
