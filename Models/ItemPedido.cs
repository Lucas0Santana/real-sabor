using novo_sabor.Models;

namespace novo_sabor.Models
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int? MedidaId { get; set; }
        public Medida? Medida { get; set; }
        public int? ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public int Qtde { get; set; }
        public float ValorParcial { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

    }
}

// ===========================
// Pedido: 234
// ----------------------------
// 1x Agua 500ml - R$ 3,00 
// 2x Bola de Sorvete - R$ 5,00