using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Everything.Models;

namespace Everything.Pages_Transactions
{
    public class DetailsModel : PageModel
    {
        private readonly EverythingContext _context;

        public DetailsModel(EverythingContext context)
        {
            _context = context;
        }

        public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transaction = await _context.Transaction.FirstOrDefaultAsync(m => m.id == id);

            if (Transaction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
