﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catholirism.Data;
using Catholirism.Model;

namespace Catholirism.Pages.CRUDReserva
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly Catholirism.Data.CatholirismContexto _context;

        public DeleteModel(Catholirism.Data.CatholirismContexto context)
        {
            _context = context;
        }

        [BindProperty]
        public Reserva Reserva { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                    .Include(r => r.Cliente)
                    .Include(r => r.PacoteTuristico)
                    .FirstOrDefaultAsync(m => m.Id == id);

            if (reserva == null)
            {
                return NotFound();
            }
            else
            {
                Reserva = reserva;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas.FindAsync(id);
            
            if (reserva != null)
            {
                reserva.isDeleted = true;
                Reserva = reserva;
                _context.Reservas.Update(Reserva);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
