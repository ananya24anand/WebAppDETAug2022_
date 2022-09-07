using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppDETAug2022_.Models;

namespace WebAppDETAug2022_.Data
{
    public class WebAppDETAug2022_Context : DbContext
    {
        public WebAppDETAug2022_Context (DbContextOptions<WebAppDETAug2022_Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppDETAug2022_.Models.Booking> Booking { get; set; } = default!;
    }
}
