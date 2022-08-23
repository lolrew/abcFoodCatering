using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ABC_FoodCatering.Models;

namespace ABC_FoodCatering.Areas.Identity.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ABC_FoodCatering.Models.ApplicationDbContext _context;

        public IndexModel(ABC_FoodCatering.Models.ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
