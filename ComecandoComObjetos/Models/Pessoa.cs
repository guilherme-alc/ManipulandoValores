namespace ComecandoComObjetos.Models
{
    internal class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto
        {
            get => $"{Nome} {Sobrenome}";
        }
        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá eu sou {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}
