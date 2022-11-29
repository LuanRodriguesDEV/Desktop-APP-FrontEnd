

using System;

namespace MyCheef.Models
{
    public class Pedido
    {

        public int Id { get; set; }
        public int ComandaId { get; set; }
    
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public bool IsExcluido { get; set; }
        public DateTime Horas { get; set; }
        public DateTime? HoraRemovida { get; set; }


       
        public Produto Produto { get; set; }


    }
}
