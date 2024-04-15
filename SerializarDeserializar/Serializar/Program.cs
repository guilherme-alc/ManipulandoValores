using Serializar.Models;

namespace SerializarDeserializar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;

            ListaDeVendas listaVenda = new ListaDeVendas("Abril");
            Produto produto1 = new Produto(1, "Material de escritório", 25.00M, dataAtual);
            Produto produto2 = new Produto(2, "Licença de software", 110.00M, dataAtual);

            listaVenda.AdicionarVenda(produto1);
            listaVenda.AdicionarVenda(produto2);

            listaVenda.GerarArquivoJson();

        }
    }
}
