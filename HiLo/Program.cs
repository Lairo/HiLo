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
            Console.WriteLine($"Guess umber between 1 and {HiLoGame.GetPot()}");
            HiLo.Hint();
            while (HiLo.Getpot() > )
            {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint");
                Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiloGame.Guess(false);
                else if (key == '?') HiloGame.Hint();
                else return;
            }
            Console.WriteLine("The pot is empty. Bye!");
        }
    }
}
