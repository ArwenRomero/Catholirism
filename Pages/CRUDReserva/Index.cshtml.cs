using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catholirism.Data;
using Catholirism.Model;

namespace Catholirism.Pages.CRUDReserva
{
    public class IndexModel : PageModel
    {
        private readonly Catholirism.Data.CatholirismContexto _context;

        public IndexModel(Catholirism.Data.CatholirismContexto context)
        {
            _context = context;
        }

        public IList<Reserva> Reserva { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Reserva = await _context.Reservas
                .Include(r => r.Cliente)
                .Include(r => r.PacoteTuristico)
                .Where(r => !r.isDeleted)
                .ToListAsync();
        }
    }
}
