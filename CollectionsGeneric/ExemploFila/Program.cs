namespace ExemploFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estrutura de dados do tipo FIFO - first in first out
            Queue<int> fila = new Queue<int>();
            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(7);
            fila.Enqueue(1);
            fila.Enqueue(6);

            Console.WriteLine("Fila de inteiros:");
            foreach (int item in fila)
            {
                Console.Write(item + " ");
            }

            //para remover um elemento da fila não é preciso passa parâmetro, pois ele remove o primeiro elemento automaticamente
            fila.Dequeue();
        }
    }
}
