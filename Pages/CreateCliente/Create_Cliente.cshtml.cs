using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catholirism.Data;
using Catholirism.Model;

namespace Catholirism.Pages.CreateCliente
{
    public class Create_ClienteModel : PageModel
    {

        private readonly CatholirismContexto _context;

        public Create_ClienteModel(CatholirismContexto context)
        {
            _context = context;
        }

        [BindProperty]
        public required Cliente Cliente { get; set; }


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


            _context.Clientes.Add(Cliente);
            _context.SaveChanges();

            Mensagem = $"Cliente '{Cliente.ClienteNome}' cadastrado com sucesso!";

            // Simular o cadastro do destino
            //           BDCliente.Clientes.Add(new Cliente
            //         {
            //               ClienteId = BDCliente.Clientes.Count + 1,
            //               ClienteNome = Cliente.ClienteNome,
            //               ClienteEmail = Cliente.ClienteEmail,
            //               ClienteTelefone = Cliente.ClienteTelefone
            //           });

            return RedirectToPage();
        }
    }
}

