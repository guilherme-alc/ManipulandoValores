namespace SwitchCaseBasico;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite uma letra:");
        string letra = Console.ReadLine();

        switch(letra) 
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("É vogal");
                break;
            default:
                Console.WriteLine("Não é vogal");
                break;
        }
    }
}
