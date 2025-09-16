namespace novo_sabor.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public ICollection<Sabor> Sabores { get; set; }
        public ICollection<ItemPedido> Itens { get; set; }
    }
}