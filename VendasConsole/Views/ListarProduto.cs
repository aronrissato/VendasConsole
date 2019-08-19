using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarProduto
    {
        public static void Renderizar()
        {
            DAL.ProdutoDAO.ListarProdutos();
            Console.WriteLine("  -- LISTAR PRODUTOS --  \n");
            foreach (Produto produtoCadastrado in DAL.ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
