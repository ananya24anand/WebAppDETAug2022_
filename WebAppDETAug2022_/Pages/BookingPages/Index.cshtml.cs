using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppDETAug2022_.Data;
using WebAppDETAug2022_.Models;

namespace WebAppDETAug2022_.Pages.BookingPages
{
    public class IndexModel : PageModel
    {
        private readonly WebAppDETAug2022_.Data.WebAppDETAug2022_Context _context;

        public IndexModel(WebAppDETAug2022_.Data.WebAppDETAug2022_Context context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Booking != null)
            {
                Booking = await _context.Booking.ToListAsync();
            }
        }
    }
}
