namespace Serializar.Models
{
    internal class Produto
    {
        public Produto(int id, string nome, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
