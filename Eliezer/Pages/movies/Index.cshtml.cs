#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Eliezer.Data;
using Eliezer.Models;

namespace Eliezer.Pages.movies
{
#pragma warning disable
#pragma warning disable
    public class IndexModel : PageModel
    {
        private readonly Eliezer.Data.EliezerContext _context;

        public IndexModel(Eliezer.Data.EliezerContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
#pragma warning restore
#pragma warning restore
    }
}
