using Catholirism.Model;

namespace Catholirism.Data
{
    public static class DbInitializer
    {
        public static void Inicializar(CatholirismContexto contexto)
        {
            contexto.Database.EnsureCreated();

            if (contexto.Clientes.Any() || contexto.Destinos.Any() || contexto.Pacotes_Turisticos.Any())
                return;
        }
    }
}
