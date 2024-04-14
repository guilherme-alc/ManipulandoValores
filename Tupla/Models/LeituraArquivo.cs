namespace Tupla.Models
{
    internal class LeituraArquivo
    {
        //Tupla em método
        public static (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                //Caso consiga ler o arquivo, retorna true, as linhas do arquivo e a quantidade de linhas
                return (true, linhas, linhas.Length);
            } 
            catch (Exception)
            {
                //Caso não consiga, retorna false, lista de string vazia, 0 quantidade de linhas
                return (false, new string[0], 0);
            }
        }
    }
}
