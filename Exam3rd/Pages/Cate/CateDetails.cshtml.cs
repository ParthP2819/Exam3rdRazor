using Exam3rd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Exam3rd.Pages.Cate
{
    public class CateDetailsModel : PageModel
    {
        private readonly Exam3rd.Data.ApplicationDbContext _context;

        public CateDetailsModel(Exam3rd.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categoriesss == null)
            {
                return NotFound();
            }

            var category = await _context.Categoriesss.FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                Category = category;
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
