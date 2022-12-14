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
    public class DetailsModel : PageModel
    {
        private readonly ABC_FoodCatering.Models.ApplicationDbContext _context;

        public DetailsModel(ABC_FoodCatering.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order.FirstOrDefaultAsync(m => m.orderID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
