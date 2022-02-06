using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPC_Authentication.Models;

namespace RPC_Authentication.Pages.UsersList
{
    public class UserFormModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserFormModel(ApplicationDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
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
            var user = new IdentityUser
            {
                UserName = UserRPC.Username
            };
            var result = await _userManager.CreateAsync(user, UserRPC.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                _db.Add(UserRPC);
                await _db.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine("succeed");
                return RedirectToPage("/Index");
                
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            System.Diagnostics.Debug.WriteLine("fail");
            return Page();
        }
    }
}
