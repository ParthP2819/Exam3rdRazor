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
    public class DeleteModel : PageModel
    {
        private readonly Exam3rd.Data.ApplicationDbContext _context;

        public DeleteModel(Exam3rd.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Productss == null)
            {
                return NotFound();
            }

            var product = await _context.Productss.FirstOrDefaultAsync(m => m.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Productss == null)
            {
                return NotFound();
            }
            var product = await _context.Productss.FindAsync(id);

            if (product != null)
            {
                Product = product;
                _context.Productss.Remove(Product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
