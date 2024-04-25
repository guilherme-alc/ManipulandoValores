namespace ComecandoComObjetos.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(Curso curso, string nome, string sobrenome)
        {
            CursoMatriculado = curso;
            Nome = nome;
            Sobrenome = sobrenome;
        }
        Curso CursoMatriculado { get; set; }
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou estudante do curso {CursoMatriculado.Nome}");
        }
    }
}
