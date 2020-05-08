using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication4.Models.WebApplication4Context _context;

        public IndexModel(WebApplication4.Models.WebApplication4Context context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}
