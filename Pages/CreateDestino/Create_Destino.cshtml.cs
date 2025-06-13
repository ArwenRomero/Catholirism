using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Catholirism.Model;
using Catholirism.Data;

namespace Catholirism.Pages.CreateDestino;

public class CreateDestinoModel : PageModel
{

    private readonly CatholirismContexto _context;

    public CreateDestinoModel(CatholirismContexto context)
    {
        _context = context;
    }

    [BindProperty]
    public required Destino Destino { get; set; }

    [TempData]
    public string Mensagem { get; set; } = string.Empty;


    public void OnGet()
    {
        
    }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }


        _context.Destinos.Add(Destino);
        _context.SaveChanges();

        Mensagem = $"Destino '{Destino.Nome}' cadastrado com sucesso!";

        // Simular o cadastro do destino
//        BDDestino.Destinos.Add(new Destino
//        {
//            Id = BDDestino.Destinos.Count + 1,
//            Nome = Destino.Nome,
//           Pais = Destino.Pais
//        });

        return RedirectToPage();
    }
}
