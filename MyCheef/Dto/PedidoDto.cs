using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCheef.Dto
{
    internal class PedidoDto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int QTD { get; set; }
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
        public string Funcionario { get; set; }
    }
}
