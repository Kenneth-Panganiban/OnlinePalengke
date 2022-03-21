#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlinePalengke.Data;
using OnlinePalengke.sheet;

namespace OnlinePalengke.Pages.main2
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly OnlinePalengke.Data.OnlinePalengkeContext _context;

        public IndexModel(OnlinePalengke.Data.OnlinePalengkeContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
