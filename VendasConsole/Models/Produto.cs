using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Produto
    {
        //Construtor
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        //Atributos ou propriedades
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString()
        {
            return "Nome: " + Nome + " | Preco: " + Preco.ToString("C") + " | Qnt em estoque: " + Quantidade;
        }

        public override bool Equals(object obj)
        {
            Produto p = (Produto)obj;
            if (p.Nome.Equals(Nome) && p.Preco.Equals(Preco))
            {
                return true;
            }
            return false;
        }
    }
}
