using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            DAL.ClienteDAO.ListarClientes();
            Console.WriteLine("  -- LISTAR CLIENTES --  ");
            foreach (var clientesCadastrados in DAL.ClienteDAO.ListarClientes())
            {
                Console.WriteLine(clientesCadastrados);
            }
        }
    }
}
