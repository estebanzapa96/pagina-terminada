using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages_cafe
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DetailsModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

      public cafetales cafetales { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.cafetales == null)
            {
                return NotFound();
            }

            var cafetales = await _context.cafetales.FirstOrDefaultAsync(m => m.ID == id);
            if (cafetales == null)
            {
                return NotFound();
            }
            else 
            {
                cafetales = cafetales;
            }
            return Page();
        }
    }
}
