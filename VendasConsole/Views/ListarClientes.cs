﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            DAL.ClienteDAO.ListarClientes();
            Console.WriteLine("  -- LISTAR CLIENTES --  ");
            foreach (Cliente clientesCadastrados in DAL.ClienteDAO.ListarClientes())
            {
                Console.WriteLine(clientesCadastrados);
            }
        }
    }
}
