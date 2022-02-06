using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPC_Authentication.Models;

namespace RPC_Authentication.Pages.UsersList
{
    public class UsersInDBModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public UsersInDBModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<UserRPC> Users { get; set; }

        public async Task OnGet()
        {
            Users = await _db.UserRPC.ToListAsync();
        }
    }
}
