namespace ComecandoComObjetos.Models
{
    internal class Curso
    {
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
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno(Pessoa aluno)
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
        }
    }
}
