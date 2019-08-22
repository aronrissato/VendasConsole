using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;
using VendasConsole.DAL;

namespace VendasConsole.Views
{
    class ListarVendedor
    {
        public static void Renderizar()
        {
            Console.WriteLine("-- LISTAR VENDEDORES --");
            foreach (Vendedor vendedoresCadastrados in VendedorDAO.ListarVendedor())
            {
                Console.WriteLine(vendedoresCadastrados);
            }
        }
    }
}
