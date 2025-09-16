namespace novo_sabor.Models
{
    public class Sabor
    {
        public int SaborId { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public ICollection<Unidade> Unidades { get; set; }

    }
}