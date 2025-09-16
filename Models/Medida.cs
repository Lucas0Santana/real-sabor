namespace novo_sabor.Models
{
    public class Medida
    {
        public int Id { get; set; }
        public float Preco { get; set; }
        public int SaborId { get; set; }
        public int UnidadeId { get; set; }
    }
}