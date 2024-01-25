using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDApp.Data;
using CRUDApp.Model;

namespace CRUDApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CRUDApp.Data.CRUDAppContext _context;

        public IndexModel(CRUDApp.Data.CRUDAppContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
