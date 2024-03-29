﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine("  -- CADASTRAR VENDEDOR --  ");
            Console.WriteLine("Digite o nome do vendedor:");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do vendedor:");
            v.Cpf = Console.ReadLine();


            if (Validacao.ValidarCpf(v.Cpf))
            {
                if (VendedorDAO.CadastrarVendedor(v) == true)
                {
                    Console.WriteLine("Vendedor cadastrado!");
                }
                else
                {
                    Console.WriteLine("Vendedor já existe!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
    }
}
