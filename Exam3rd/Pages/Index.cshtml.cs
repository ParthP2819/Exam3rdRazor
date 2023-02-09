using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exam3rd.Data;
using Exam3rd.Model;

namespace Exam3rd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Exam3rd.Data.ApplicationDbContext _context;

        public IndexModel(Exam3rd.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Productss != null)
            {
                Product = await _context.Productss
                .Include(p => p.category).ToListAsync();
            }
        }
    }
}
