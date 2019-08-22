using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;
using VendasConsole.DAL;


namespace VendasConsole.Views
{
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            Venda v = new Venda();
            Console.WriteLine("  -- CADASTRAR VENDA --  ");
            Console.WriteLine("Digite o nome do cliente:");
            Console.ReadLine();

            Console.WriteLine("Digite o nome do vendedor:");
            v.Cpf = Console.ReadLine();
        }
    }
}
