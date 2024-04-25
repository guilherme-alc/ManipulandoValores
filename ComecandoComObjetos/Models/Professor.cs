namespace ComecandoComObjetos.Models
{
    internal class Professor : Pessoa
    {
        public Professor(Curso curso, string nome, string sobrenome) 
        {
            Curso = curso;
            Nome = nome;
            Sobrenome = sobrenome;
        }
        Curso Curso { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e sou professor do curso {Curso.Nome}");
        }
    }
}
