using ComecandoComObjetos.Models;

namespace ComecandoComObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso cursoAds = new Curso("Análise e Desenvolvimento de Sistemas");
            Professor professor = new Professor(cursoAds, nome: "Chester", sobrenome: "Bennington");
            cursoAds.Professor = professor;

            Aluno aluno1 = new Aluno(cursoAds, nome: "Guilherme", sobrenome: "Augusto");
            Aluno aluno2 = new Aluno(cursoAds, nome: "Andreas", sobrenome: "Kisser");
            Aluno aluno3 = new Aluno(cursoAds, nome: "Chico", sobrenome: "Moreno");
            aluno3.Idade = 19;

            aluno3.Apresentar();
            professor.Apresentar();


            cursoAds.AdicionarAluno(aluno1);
            cursoAds.AdicionarAluno(aluno2);
            cursoAds.AdicionarAluno(aluno3);
            cursoAds.ExibirAlunosMatriculados();
            cursoAds.RemoverAluno(aluno3);
            cursoAds.ExibirAlunosMatriculados();
            System.Object obj = new System.Object();
        }
    }
}
