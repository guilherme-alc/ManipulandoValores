using ComecandoComObjetos.Models;

namespace ComecandoComObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(nome: "Guilherme", sobrenome: "Augusto");
            Pessoa p2 = new Pessoa(nome: "Andreas", sobrenome: "Kisser");

            Pessoa p3 = new Pessoa();
            p3.Nome = "Chester";
            p3.Sobrenome = "Bennington";

            Pessoa p4 = new Pessoa();
            p4.Nome = "Chico";
            p4.Sobrenome = "Moreno";


            Curso curso = new Curso();
            curso.Nome = "Análise e Desenvolvimento de Sistemas";
            curso.Alunos = new List<Pessoa>();

            curso.AdicionarAluno(p1);
            curso.AdicionarAluno(p2);
            curso.AdicionarAluno(p3);
            curso.AdicionarAluno(p4);
            curso.ExibirAlunosMatriculados();
            curso.RemoverAluno(p4);
            curso.ExibirAlunosMatriculados();
        }
    }
}
