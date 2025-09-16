namespace novo_sabor.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public float ValorTotal { get; set; }
        public string Status { get; set; }
        public ICollection<ItemPedido> Itens { get; set; }
    }
}