using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {
        private ClienteDAO() { }

        private static List<Cliente> clientes = new List<Cliente>();
        /// <summary>
        /// Cadastra um cliente dentro da lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns>
        /// Por enquanto este metodo não retorna nada
        /// </returns>

        public static bool CadastrarCliente(Cliente c)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf.Equals(c.Cpf))
                {
                    return false;
                }
            }
            clientes.Add(c);
            return true;
        }

        public static bool ValidarCpf(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;

            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * (multiplicador1[i]);
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            int soma2 = 0;

            for (int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma2 % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }


        public static List<Cliente> ListarClientes()
        {
            return clientes;
        }
    }
}
