using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPC_Authentication.Models;

namespace RPC_Authentication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexModel(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        //[HttpGet]
        //[AllowAnonymous]
        //public IActionResult Login()
        //{
          //  return Page();
        //}

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> OnLogin(UserRPC user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Username, user.Password,false,false);

                if (result.Succeeded)
                {
                    System.Diagnostics.Debug.WriteLine("succeed");
                    return RedirectToPage("/UsersList/UserForm");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            System.Diagnostics.Debug.WriteLine("fail");
            return Page();
        }

        public void OnGet()
        {

        }
    }
}