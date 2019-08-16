using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendedorDAO
    {
        private VendedorDAO() { }

        private static List<Vendedor> vendedores = new List<Vendedor>();
        /// <summary>
        /// Cadastra um vendedor dentro da lista
        /// </summary>
        /// <param name="v"></param>
        /// <returns>
        /// Por enquanto este metodo não retorna nada
        /// </returns>

        public static bool CadastrarVendedor(Vendedor v)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if (vendedorCadastrado.Cpf.Equals(v.Cpf))
                {
                    return false;
                }
            }
            vendedores.Add(v);
            return true;
        }

        public static List<Vendedor> ListarVendedor()
        {
            return vendedores;
        }

    }
}
