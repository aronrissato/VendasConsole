using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine("  -- CADASTRAR CLIENTE --  ");
            Console.WriteLine("Digite o nome do cliente:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente:");
            c.Cpf = Console.ReadLine();

            
            if (DAL.ClienteDAO.ValidarCpf(c.Cpf) == true)
            { 
            if (DAL.ClienteDAO.CadastrarCliente(c) == true)
            {
                Console.WriteLine("Cliente cadastrado!");
            }
            else
            {
                Console.WriteLine("Cliente já existe!");
            }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
    }
}
