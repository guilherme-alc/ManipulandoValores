namespace ExemploLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>();
            listaDeNomes.Add("Guilherme");
            listaDeNomes.Add("Miles Kennedy");
            listaDeNomes.Add("Cliff Burton");
            listaDeNomes.Add("Chris Cornnel");
            listaDeNomes.Add("Layne Staley");

            if (listaDeNomes.Any())
            {
                Console.WriteLine("A lista possui elementos");
            }

            //organizando lista na ordem alfabética
            listaDeNomes.Sort();

            Console.WriteLine("Lista de nomes:");
            for (int i = 0; i < listaDeNomes.Count; i++)
            {
                Console.WriteLine(listaDeNomes[i]);   
            }

            //inserindo elemento em índice específico
            listaDeNomes.Insert(3, "Kamau");

            Console.WriteLine("\nExibindo com expressão lambda:");
            listaDeNomes.ForEach(x => Console.WriteLine(x));

            Console.WriteLine($"\nKamau foi inserido no índice {listaDeNomes.IndexOf("Kamau")}");
            Console.WriteLine($"\nO nome Lucas está na lista? {(listaDeNomes.Contains("Lucas")? "Sim" : "Não")}");
            //remove um item no índice especificado
            //listaDeNomes.RemoveAt(3);
            //remove uma determinada quantidade à partir do índice especificado
            //listaDeNomes.RemoveRange(1, 3);
            //remove todos os elementos
            //listaDeNomes.Clear();

        }
    }
}
