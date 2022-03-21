#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlinePalengke.sheet;

namespace OnlinePalengke.Data
{
    public class OnlinePalengkeContext : DbContext
    {
        public OnlinePalengkeContext (DbContextOptions<OnlinePalengkeContext> options)
            : base(options)
        {
        }

        public DbSet<OnlinePalengke.sheet.Class> Class { get; set; }
    }
}
