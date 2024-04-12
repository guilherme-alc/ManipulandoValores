using System.Globalization;
//configura a localização do código para US
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

namespace ManipulandoValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########################### Monetário ###########################");
            decimal valorMonetario = 1582.40M;
            
            //exibe em real
            Console.WriteLine($"{valorMonetario:C}");
            //exibe em dolar
            Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            //o ":C", siginifica currency e transforma o valor da varíavel em monetário com $, ou R$ se a localização do sistema ou do código esteve no Brasil

            Console.WriteLine("\n########################### Porcentagem ###########################");
            //exibe em formato de porcentagem
            double porcentagem = .3421;
            Console.WriteLine(porcentagem.ToString("P"));

            Console.WriteLine("\n########################### Personalizado ###########################");
            //exibe numero formatado de forma personalizada. Ex: celular.
            long numero = 31999124381;
            Console.WriteLine(numero.ToString("(##) #####-####"));

            Console.WriteLine("\n########################### Tipo DateTime ###########################");
            //obtem data e hora atual do computador
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual.ToString("dd/MM/yy HH:mm")); //algumas representações devem ser em maíusculas para diferenciar de outras, exemplo mês e minutos - MM e mm. HH representa o formato de 24 horas e hh o formato de 12 horas.

            //exibe a quantidade de dias no mês de fevereiro no ano 2024
            int qtdDiasEmFevereiro = DateTime.DaysInMonth(2024, 2);
            Console.WriteLine(qtdDiasEmFevereiro);

            //exibe somente a hora atual
            DateTime somenteHora = DateTime.Now;
            Console.WriteLine(somenteHora.ToShortTimeString());
            
            //exibe somente a data atual
            DateTime somenteData = DateTime.Now;
            Console.WriteLine(somenteHora.ToShortDateString());

            //converte uma string no formato de data válida para o tipo DateTime
            DateTime converteParaData = DateTime.Parse("10/02/2001 12:00");
            Console.WriteLine(converteParaData);

            //converter de forma segura com o TryParse, sem encerrar o programa
            string dataEmString = "09/07/2023 18:00";
            //primeiro parâmetro: a variável que quer converter
            //segundo parâmetro: o formato dessa variável
            //terceiro parâmetro: formato de cultura. Ex: formato americano mes/dia/ano, formato brasileiro dia/mes/ano, InvariantCulture para não informar.
            //quarto parâmetro: estilo do DateTime.
            //quinto parâmetro: variável de saída no formato esperado, caso consiga converter
            bool sucesso = DateTime.TryParseExact(dataEmString, 
                                   "dd/MM/yyyy HH:mm", 
                                   CultureInfo.GetCultureInfo("pt-BR"), 
                                   DateTimeStyles.None, 
                                   out DateTime dataConvertida);
            if(sucesso)
            {
                Console.WriteLine($"Conversão feita! Data: {dataConvertida}");
            } else
            {
                Console.WriteLine($"{dataEmString} não é uma data válida");
            }

            //forma simples
            bool sucesso2 = DateTime.TryParse(dataEmString, out DateTime dataConvertida2);
            if(sucesso2)
            {
                Console.WriteLine($"Conversão feita! Data: {dataConvertida2}");
            } else
            {
                Console.WriteLine($"{dataEmString} não é uma data válida");
            }
        }
    }
}
