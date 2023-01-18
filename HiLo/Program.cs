using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HiLo.");
            Console.WriteLine($"Guess number between 1 and {HiLoGame.MAXIMUM}.");
            HiLoGame.Hint();

            HiLoGame.random = new Random(1);
            Random seededRandom = new Random(1);
            Console.Write("The first 20 numbers will be: ");
            for (int i = 0; i < 10; i++)
                Console.Write($"{seededRandom.Next(1, HiLoGame.MAXIMUM + 1)}, ");

            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("\nPress h for higher, l for lower, ? to buy a hint");
                Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiLoGame.Guess(false);
                else if (key == '?') HiLoGame.Hint();
                else if (key == '0') HiLoGame.Cheat();
                else return;
            }
            Console.WriteLine("The pot is empty. Bye!");
            Console.WriteLine("Press 0  to cheat");

            
        }
    }
}
