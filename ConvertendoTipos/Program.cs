namespace ConvertendoTipos;

class Program
{
    static void Main(string[] args)
    {
        string inteiroEmLetra = "2";
        //int a = int.Parse(inteiroEmLetra); //caso não consiga converter, gera uma exceção.

        //mais seguro contra valors nulos.
        //se o valor não for nulo, também gera uma exceção.
        int a = Convert.ToInt32(null); //caso não consiga converter um valor que não existe (null) retorna 0.

        //opção mais segura, possível tratamento de erros.
        //bool a = int.TryParse(inteiroEmLetra, out numero); //retorna um boleano para a conversão.

        if(!int.TryParse(inteiroEmLetra, out int numero)) {
            Console.WriteLine("Tipo de entrada incorreto");
        }
        Console.WriteLine(a);

        //convertendo int para string.
        Console.WriteLine(numero.ToString());

        //cast implícito
        //double é um tipo de dado capaz de armazenar valores maiores e com precisão decimal. 
        //ao atribuir um int a um double, não há perda de precisão porque double é capaz de representar todos os valores de int.
        int numInteiro = 5;
        double numDecimal = numInteiro;

        //cast explícito.
        double numDecimal2 = 5.5;
        int numInteiro2 = (int) numDecimal2;
        //.5 será perdido.
    }
}
