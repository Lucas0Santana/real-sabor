namespace novo_sabor.Models
{
    public class Unidade
    {
        public int UnidadeId { get; set; }
        public string Nome { get; set; }
        public int SaborId { get; set; }
        public Sabor Sabor { get; set; }
    }
}