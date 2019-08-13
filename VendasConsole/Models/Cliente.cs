using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Cliente
    {
        //Construtor
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }

        public Cliente(string cpf)
        {
            Cpf = cpf;
            CriadoEm = DateTime.Now;
        }

        //Atributos ou propriedades
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Cliente c = (Cliente) obj;
            if(c.Nome.Equals(Nome) && c.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        }
    }
}
