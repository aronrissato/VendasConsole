using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Vendedor
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }

        public Vendedor(string cpf)
        {
            Cpf = cpf;
            CriadoEm = DateTime.Now;
        }


        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Vendedor v = (Vendedor)obj;
            if (v.Nome.Equals(Nome) && v.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        }
    }
}
