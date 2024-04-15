using Newtonsoft.Json;
namespace Deserializar.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] //Atributo
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
