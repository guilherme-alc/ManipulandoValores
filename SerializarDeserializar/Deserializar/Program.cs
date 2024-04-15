using Deserializar.Models;
using Newtonsoft.Json;
namespace Deserializar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conteudoArquivo = File.ReadAllText("Arquivos/lista-de-vendas.json");

            List<Produto> listaProdutos = JsonConvert.DeserializeObject<List<Produto>>(conteudoArquivo);

            foreach(Produto produto in listaProdutos)
            {
                Console.WriteLine($"Id: {produto.Id} \nProduto: {produto.Nome}" +
                    $"\nPreço: {produto.Preco} \nData: {produto.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
            }
        }
    }
}
