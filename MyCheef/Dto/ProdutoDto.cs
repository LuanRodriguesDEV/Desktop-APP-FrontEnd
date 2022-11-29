namespace MyCheef.Dto
{
    internal class ProdutoDto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Imprimir { get; set; }
        public string Categoria { get; set; } = null;
    }
}
