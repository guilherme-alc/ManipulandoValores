namespace ComecandoComObjetos.Models
{
    abstract class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get => _nome;

            set
            {
                try
                {
                    if (!(value == ""))
                    {
                        _nome = value;                       
                    } else
                    {
                        throw new ArgumentException("O nome não pode ser vazio");
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
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
                try
                {
                    if (value > 0)
                    {
                        _idade = value;                    
                    } else
                    {
                        throw new ArgumentException("A idade não pode ser negativa");
                    }
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá eu sou {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}
