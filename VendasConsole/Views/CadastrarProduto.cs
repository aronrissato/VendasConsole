using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("  -- CADASTRAR PRODUTO --  ");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto:");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto em estoque:");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            if (DAL.ProdutoDAO.CadastrarProduto(p) == true)
            {
                Console.WriteLine("Produto cadastrado!");
            }
            else
            {
                Console.WriteLine("Produto já existe!");
            }
        }
    }

}
