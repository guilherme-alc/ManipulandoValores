using Tupla.Models;

namespace Tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Formas de criação de tupla
            (int Id, string Nome, char Sexo) tuplaPessoa = (25987, "Guilherme Augusto", 'M');
            //Dessas formas não é possível nomear os dados:
            ValueTuple<int, string, decimal> tuplaPessoa1 = (25698, "Eric", 'M');
            var tuplaPessoa2 = Tuple.Create(26597, "Maite", 'F');
            
            
            Console.WriteLine($"Id: {tuplaPessoa.Id}");
            Console.WriteLine($"Nome: {tuplaPessoa.Nome}");
            Console.WriteLine($"Sexo: {tuplaPessoa.Sexo}");
            Console.WriteLine();
            Console.WriteLine($"Id: {tuplaPessoa2.Item1}");
            Console.WriteLine($"Nome: {tuplaPessoa2.Item2}");
            Console.WriteLine($"Sexo: {tuplaPessoa2.Item3}");
            Console.WriteLine();

            //var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
            (bool sucesso, string [] linhasArquivo, _) = LeituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

            if(sucesso)
            {
                //Console.WriteLine($"Quantidade de linhas do arquivo {quantidadeLinhas}");
                foreach(string linha in linhasArquivo)
                {
                    Console.WriteLine(linha);
                }
            } else
            {
                Console.WriteLine("Não foi possível ler o arquivo");
            }
        }
    }
}
