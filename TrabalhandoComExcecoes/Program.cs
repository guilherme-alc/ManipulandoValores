using System;
using TrabalhandoComExcecoes.Models;
namespace TrabalhandoComExcecoes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			new ExemploExcecao().Metodo1();
			try 
			{
					string[] linhasDoArquivo = File.ReadAllLines("Arquivos/pastaInexistente/arquivoDeLeitura.txt");

					foreach(string linha in linhasDoArquivo)
					{
							Console.WriteLine(linha);
					}
			}
			catch(FileNotFoundException ex) 
			{
				Console.WriteLine($"O arquivo não foi encontrado no diretório informado:\n{ex.Message}");
			}
			catch(DirectoryNotFoundException ex)
			{
				Console.WriteLine($"O diretório não foi encontrado no caminho informado:\n{ex.Message}");
			}
			catch(Exception ex)
			{
				Console.WriteLine($"Ocorreu uma exceção genérica:\n{ex.Message}");
			}
			finally
			{
				Console.WriteLine("Fluxo do programa não interrompido");
			}
		}
	}
}
