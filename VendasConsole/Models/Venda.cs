﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Models
{
    class Venda
    {
        //Construtor
        public Venda()
        {
            CriadoEm = DateTime.Now;
        }


        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItemVenda> Produtos { get; set; }
        public DateTime CriadoEm { get; set; }
    }


}
