using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;
using VendasConsole.DAL;

namespace VendasConsole.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR CLIENTES --  ");
            foreach (Cliente clientesCadastrados in ClienteDAO.ListarClientes())
            {
                Console.WriteLine(clientesCadastrados);
            }
        }
    }
}
