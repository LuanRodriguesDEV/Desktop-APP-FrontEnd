

using System;
using System.Collections.Generic;

namespace MyCheef.Models
{
    public class Caixa
    {
        public int Id { get; set; }
        public decimal SaldoInicial { get; set; }      
        public Nullable<decimal> SaldoFinalEmDinheiro { get; set; }
        public Nullable<decimal> SaldoFinalEmCartoes { get; set; }
        public DateTime DataAbertura { get; set; }    
        public Nullable<DateTime> DataFechamento { get; set; }        
        //ToDo Vincular Funcionario 
    }
}
