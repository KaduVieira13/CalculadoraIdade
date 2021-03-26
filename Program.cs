using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
              string dataDigitada;
              DateTime horaSistema = DateTime.Now;

            Console.WriteLine("---Calculadora de Idade--- \n");
            Console.WriteLine("Digite a data do seu nascimento no formato: AAAA,MM.DD");
            dataDigitada = Console.ReadLine();
            DateTime nascimentoUsuario = Convert.ToDateTime(dataDigitada);

            Console.WriteLine($"O dia do seu nascimento foi: {nascimentoUsuario.ToLongDateString()}");
            TimeSpan diasVividos = horaSistema - nascimentoUsuario;
            int diasAtuais = diasVividos.Days;
            int horasAtuais = diasVividos.Hours;
            
           
            Console.WriteLine($"Voce tem até o momento: {diasAtuais} dias de vida.");
            Console.WriteLine($"Equivalente a: {diasAtuais * horasAtuais} horas de vida.");
            
          
            


        }
    }
}
