using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Models
{
    class ItemVenda
    {
        public ItemVenda()
        {
            CriadoEm = DateTime.Now;
        }

        
        public Produto Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

               
    }
}
