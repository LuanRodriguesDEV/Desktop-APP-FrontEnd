using System.Collections.Generic;


namespace MyCheef.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public decimal Valor { get; set; }
        public bool IsImprimir { get; set; }
        public int CategoriaId { get; set; }
      
        public Categoria Categoria { get; set; }
    
        //ToDo GerenciadorCombo
    }

}
