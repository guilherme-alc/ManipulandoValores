namespace ComecandoComObjetos.Models
{
    internal class Curso
    {
        public Curso (string nome)
        {
            Alunos = new List<Aluno>();
            Nome = nome;
        }
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome do curso não pode ser nulo");
                }
                _nome = value;
            }
        }
        public List<Aluno> Alunos;
        public Professor Professor { get; set; }
        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno(Aluno aluno)
        {
            return Alunos.Remove(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }
        public void ExibirAlunosMatriculados()
        {
            Console.WriteLine($"\nQuantidade de alunos matriculados: {ObterQuantidadeDeAlunosMatriculados()}");
            Console.WriteLine("Lista de alunos matriculados:");
            Alunos.Order();
            for (int posicao = 0; posicao < Alunos.Count; posicao++)
            {
                Console.WriteLine($"{posicao + 1}º {Alunos[posicao].NomeCompleto}");
            }
            Console.WriteLine($"Professor do curso: {Professor.Nome}");
        }
    }
}
