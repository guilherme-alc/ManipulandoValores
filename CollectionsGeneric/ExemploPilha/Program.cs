namespace ExemploPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estrutura de dados do tipo LIFO - last in first out
            Stack<int> pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);

            Console.WriteLine("Pilha de inteiros:");
            Console.Write("Último elemento inserido: ");
            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            //remove o item do topo da pilha, o último inserido
            pilha.Pop();
        }
    }
}
