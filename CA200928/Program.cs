using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200928
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                var s = "Hello World!";

                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth - s.Length),
                    rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write(s);
            }
            Console.ReadKey();
        }
    }
}
