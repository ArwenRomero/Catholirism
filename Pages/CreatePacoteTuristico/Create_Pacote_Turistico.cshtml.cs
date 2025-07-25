using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Catholirism.Data;
using Catholirism.Model;

namespace Catholirism.Pages.CreatePacoteTuristico
{
    public class Create_Pacote_TuristicoModel : PageModel
    {

        private readonly CatholirismContexto _context;

        public Create_Pacote_TuristicoModel(CatholirismContexto context)
        {
            _context = context;
        }

        [BindProperty]
        public required Pacote_Turistico PacoteTuristico { get; set; } = new();

        [TempData]
        public string Mensagem { get; set; } = string.Empty;

        [BindProperty]
        public List<int> DestinosSelecionados { get; set; } = new();

        public List<Destino> DestinosDisponiveis { get; set; } = new();

        public void OnGet()
        {
            DestinosDisponiveis = _context.Destinos.OrderBy(d => d.Nome).ToList();
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
               
                return Page();
            }

            PacoteTuristico.PacoteDestinos = _context.Destinos
                .Where(d => DestinosSelecionados.Contains(d.Id))
                .Select(d => new PacoteDestino
                {
                    Pacote = PacoteTuristico,
                    Destino = d
                })
                .ToList();


            PacoteTuristico.ReservasAtuais = 0;


            _context.Pacotes_Turisticos.Add(PacoteTuristico);
            _context.SaveChanges();
//            BDPacote_Turistico.Pacote.Add(PacoteTuristico);


            Mensagem = $"Pacote '{PacoteTuristico.Nome}' cadastrado com sucesso!";

            return RedirectToPage();
        }
    }
}
