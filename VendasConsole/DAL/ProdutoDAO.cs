﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ProdutoDAO
    {
        private ProdutoDAO() { }

        private static List<Produto> produtos = new List<Produto>();
        /// <summary>
        /// Cadastra um produto dentro da lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns>
        /// Por enquanto este metodo não retorna nada
        /// </returns>

        public static bool CadastrarProduto(Produto p)
        {
            if (BuscarProdutoPorNome(p) != null)
            {
                return false;
            }
            produtos.Add(p);
            return true;
        }

        public static Produto BuscarProdutoPorNome(Produto p)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (produtoCadastrado.Nome.Equals(p.Nome))
                {
                    return produtoCadastrado;
                }
            }
            return null;
        }

        public static

        public static List<Produto> ListarProdutos()
        {
            return produtos;
        }
    }
}
