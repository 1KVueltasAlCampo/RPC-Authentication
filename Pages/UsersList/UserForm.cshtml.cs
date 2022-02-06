using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPC_Authentication.Models;

namespace RPC_Authentication.Pages.UsersList
{
    public class UserFormModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public UserFormModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public UserRPC UserRPC { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Add(UserRPC);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
