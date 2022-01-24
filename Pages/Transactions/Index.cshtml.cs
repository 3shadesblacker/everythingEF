using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Everything.Models;

namespace Everything.Pages_Transactions
{
    public class IndexModel : PageModel
    {
        private readonly EverythingContext _context;

        public IndexModel(EverythingContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Articles { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public async Task OnGetAsync()
        {
            var transactions = from t in _context.Transaction
                 select t;
            if (!string.IsNullOrEmpty(SearchString))
            {
                transactions = transactions.Where(s => s.Article.Contains(SearchString));
            }
            Transaction = await _context.Transaction.ToListAsync();
        }
    }
}
