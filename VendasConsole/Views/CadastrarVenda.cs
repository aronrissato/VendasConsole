using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;


namespace VendasConsole.Views
{
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            int qntitvenda = 0;
            int continuarcadastrandoprd = 1;
            Venda venda = new Venda();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            Cliente c = new Cliente();

            Console.WriteLine("  -- CADASTRAR VENDA --  ");
            Console.WriteLine("Digite o CPF do cliente:");
            c.Cpf = Console.ReadLine();
            c = ClienteDAO.BuscarClientePorCpf(c);


            if (c != null)
            {
                venda.Cliente = c;
                Console.WriteLine("Digite o CPF do vendedor: ");
                v.Cpf = Console.ReadLine();
                v = VendedorDAO.BuscarVendedorPorCpf(v);

                if (v != null)
                {
                    venda.Vendedor = v;

                    do
                    {
                        Console.WriteLine("Digite o nome do produto: ");
                        p.Nome = Console.ReadLine();
                        p = ProdutoDAO.BuscarProdutoPorNome(p);

                        if (p != null)
                        {
                            if (p.Quantidade > 0)
                            {
                                Console.WriteLine($"Digite a quantidade de {p.Nome} que deseja: ");
                                qntitvenda = Convert.ToInt32(Console.ReadLine());

                                if (p.Quantidade >= qntitvenda)
                                {
                                    venda.Produtos.Add(new ItemVenda { Produto = p, Quantidade = qntitvenda });
                                }
                            }
                            else
                            {
                                Console.WriteLine("Produto não possui estoque");
                            }
                            
                        }

                        Console.WriteLine("Para cadastrar mais produtos digite 1.\n");
                        Console.WriteLine("Para continuar digite 0.");
                        continuarcadastrandoprd = Convert.ToInt32(Console.ReadLine());

                    } while (continuarcadastrandoprd != 0);

                    Console.WriteLine("Venda cadastrada!");


                }
                else
                {
                    Console.WriteLine("Esse vendedor não existe!");
                }

            }
            else
            {
                Console.WriteLine("Esse cliente não existe!");
            }
        }
    }
}
