using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;
using VendasConsole.Views;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ResetColor();
            int opcao;
            //List<Cliente> clientes = new List<Cliente>();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  -- PROJETO VENDAS CONSOLE --  \n");
                Console.ResetColor();
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Cadastrar vendedor");
                Console.WriteLine("4 - Listar vendedor");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;

                    case 2:
                        ListarClientes.Renderizar();
                        break;

                    case 3:
                        CadastrarVendedor.Renderizar();
                        break;

                    case 4:
                        ListarVendedor.Renderizar();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\n\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
