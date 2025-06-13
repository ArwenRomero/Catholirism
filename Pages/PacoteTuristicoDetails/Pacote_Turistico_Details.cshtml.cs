using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catholirism.Data;
using Catholirism.Model;

namespace Catholirism.Pages.PacoteTuristicoDetails
{
    public class Pacote_Turistico_DetailsModel : PageModel
    {
        private readonly CatholirismContexto _context;

        public Pacote_Turistico_DetailsModel(CatholirismContexto context)
        {
            _context = context;
        }

        [TempData]
        public string Mensagem { get; set; } = string.Empty;

        public Pacote_Turistico? Pacote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Mensagem = "ID do pacote tur�stico n�o encontrado.";
                return Page();
            }

            Pacote = await _context.Pacotes_Turisticos
                .Include(p => p.PacoteDestinos)
                .ThenInclude(pd => pd.Destino)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (Pacote == null)
            {
                Mensagem = "Pacote tur�stico n�o encontrado.";
            }

            return Page();
        }
    }
}
