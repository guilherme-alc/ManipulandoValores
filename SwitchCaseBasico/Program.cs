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

        string opcao;
        bool exibirMenu = true;
        while(exibirMenu) {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Digite sua opção:");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine("4 - Encerrar");
            opcao = Console.ReadLine()!;

            switch(opcao) {
                case "1":
                    Console.WriteLine("Cadastro de cliente");    
                    break;
                case "2":
                    Console.WriteLine("Busca de cliente");    
                    break;
                case "3":
                    Console.WriteLine("Apagar cliente");    
                    break;
                case "4":
                    Console.WriteLine("Encerrar");
                    exibirMenu = false;    
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;                    
            }
        }
    }
}
