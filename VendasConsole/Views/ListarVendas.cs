using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarVendas
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR VENDAS --  \n");
            foreach (Venda vendaCadastrada in VendaDAO.ListarVendas())
            {
                Console.WriteLine("Cliente: "
                    + vendaCadastrada.Cliente.Nome);
                Console.WriteLine("Vendedor: "
                    + vendaCadastrada.Vendedor.Nome);
                Console.WriteLine("Produto: "
                    + vendaCadastrada.Produto.Nome);
                Console.WriteLine("Quantidade: "
                    + vendaCadastrada.Quantidade);
                double total = vendaCadastrada.Quantidade
                    * vendaCadastrada.Produto.Preco;
                Console.WriteLine("Total: " +
                     total.ToString("C2"));
                Console.WriteLine("\n");
            }
        }
    }
}
