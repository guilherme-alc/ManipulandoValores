using System.Collections;
using System.Linq;
namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable boletim = new Hashtable() 
            {
                { "Jon", new Hashtable() 
                    { 
                        {"1 Periodo", new ArrayList(6) {60, 87, 68, 96, 77, 90} },
                        {"2 Periodo", new ArrayList(6) {80, 81, 96, 69, 60, 87} },
                        {"3 Periodo", new ArrayList(6) {70, 82, 78, 70, 66, 74} },
                    } 
                } ,
                {
                    "Logan", new Hashtable()
                    {
                        {"1 Periodo", new ArrayList(6) {70, 55, 67, 85, 67, 98} },
                        {"2 Periodo", new ArrayList(6) {70, 57, 90, 80, 66, 68} },
                        {"3 Periodo", new ArrayList(6) {77, 70, 60, 74, 64, 64} }
                    }
                }
            };
            boletim.Add("Guilherme", new Hashtable() { { "1 Periodo", new ArrayList() { 80, 69, 95, 77, 100, 76 } } });

            //boletim["Guilherme"] = new Hashtable() { { "2 Periodo", new ArrayList() { 66, 76, 95, 84, 90, 100 } } }; Não funciona tem que fazer casting

            ((Hashtable)boletim["Guilherme"]).Add("2 Periodo", new ArrayList() { 66, 76, 95, 84, 90, 100 });
            ((Hashtable)boletim["Guilherme"]).Add("3 Periodo", new ArrayList() { 70, 76, 90, 84, 88, 96 });

            int ultimaNota2pGuilherme = (int) (((ArrayList) ((Hashtable)boletim["Guilherme"])["2 Periodo"])[5]);

            //Obter média das notas do 2 periodo do guilherme:
            ArrayList notasGuilherme = ((ArrayList) ((Hashtable)boletim["Guilherme"])["3 Periodo"]);
            Console.WriteLine(ultimaNota2pGuilherme);

            double media = 0;
            foreach(int nota in notasGuilherme)
            {
                media += nota;
            }
            media = media / notasGuilherme.Count;
            Console.WriteLine(media);

            //Percorrer todas as informações
            foreach(DictionaryEntry aluno in boletim)
            {
                Console.WriteLine($"\tAluno: {aluno.Key}");
                foreach(DictionaryEntry periodo in (Hashtable) aluno.Value)
                {
                    Console.Write($"{periodo.Key}\t");
                    foreach (int nota in (ArrayList) periodo.Value)
                    {
                        Console.Write(nota + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
        }
    }
}
