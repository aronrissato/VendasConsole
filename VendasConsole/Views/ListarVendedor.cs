using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarVendedor
    {
        public static void Renderizar()
        {
            DAL.VendedorDAO.ListarVendedor();
            Console.WriteLine("-- LISTAR VENDEDORES --");
            foreach (Vendedor vendedoresCadastrados in DAL.VendedorDAO.ListarVendedor())
            {
                Console.WriteLine(vendedoresCadastrados);
            }
        }
    }
}
