namespace ExemploDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estrutura que armazena chave e valor
            Dictionary<string, double> listaDeCompras = new Dictionary<string, double>();
            listaDeCompras.Add("Detergente", 6.59);
            listaDeCompras.Add("Amaciante", 25.99);
            listaDeCompras.Add("Ração", 120.00);
            listaDeCompras.Add("Pão", 8.50);
            listaDeCompras.Add("Macarrão", 6.79);

            //para remover tem que passar somente a chave como parâmetro
            listaDeCompras.Remove("Ração");
            //alterar valor
            listaDeCompras["Pão"] = 6.50;

            List<string> produtosComprados = listaDeCompras.Keys.ToList();
            Console.WriteLine("Lista de produtos comprados:");
            foreach (string produto in produtosComprados)
            {
                Console.WriteLine(produto);
            }

            double gastoTotal = listaDeCompras.Values.Sum();
            Console.WriteLine($"Gasto total: {gastoTotal:C}");

            Console.WriteLine("\nLista de compra detalhada:");
            foreach(KeyValuePair<string, double> produto in listaDeCompras)
            {
                Console.WriteLine($"Produto: {produto.Key}, preço: {produto.Value}");
            }

            //buscando produto no dicionário
            string chaveBuscada = "Amaciante";
            if(listaDeCompras.ContainsKey(chaveBuscada))
            {
                Console.WriteLine($"\nProduto {chaveBuscada} existe na lista");
            }

            //buscando valor no dicionário
            double valorBuscado = 6.79;
        }
    }
}
