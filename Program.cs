using System;
using System.Threading;
namespace Cronometro
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção.");
            Console.WriteLine("M - Minutos => Ex: 1m");
            Console.WriteLine("S - Segundos => Ex: 50s");
            Console.WriteLine("0 = Sair");
                        
            // Para converter apenas o último caractere para lowercase e isolá-lo. 
             string data = Console.ReadLine().ToLower();
             char type = char.Parse(data.Substring(data.Length - 1, 1));
            // Para pegar apenas os números que antecedem o último caractere.
             int time = int.Parse(data.Substring(0, data.Length - 1));           
             int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if (time == '0')
                System.Environment.Exit(0);
                
                
            Start(time * multiplier);
        }
        
        static void Start(int time)
        {            
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");

        }
    }
}
