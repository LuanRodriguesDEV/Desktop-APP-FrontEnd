
using System;
using System.Collections.Generic;

namespace MyCheef.Models
{
    public class Comanda
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Mesa { get; set; }
      
        public decimal Valor { get; set; }
        public bool Estado { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public int CaixaId { get; set; }
        
        
       
    }

}
