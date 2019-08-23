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
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }       
    }
}
