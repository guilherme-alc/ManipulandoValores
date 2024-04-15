using Newtonsoft.Json;

namespace Serializar.Models
{
    internal class ListaDeVendas
    {
        public ListaDeVendas(string mes)
        {
            Mes = mes;
            Lista = new List<Produto>();
        }
        public string Mes { get; set; }
        public List<Produto> Lista;
        public void AdicionarVenda(Produto produto)
        {
            Lista.Add(produto);
        }
        public void RemoverVenda(Produto produto)
        {
            Lista.Remove(produto);
        }
        public void GerarArquivoJson()
        {
            string listaDeVendasSerializada = JsonConvert.SerializeObject(Lista, Formatting.Indented);
            string arquivoJson = "lista-de-vendas.json";
            File.WriteAllText(arquivoJson, listaDeVendasSerializada);
            Console.WriteLine($"Caminho do arquivo em {Path.GetFullPath(arquivoJson)}");
        }
    }
}
