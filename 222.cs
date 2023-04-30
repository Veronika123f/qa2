using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick     brown   fox  jumps   over the  lazy  dog.";
            int maxSpaces = 0;
            int currentSpaces = 0;

            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    currentSpaces++;
                    if (currentSpaces > maxSpaces)
                    {
                        maxSpaces = currentSpaces;
                    }
                }
                else
                {
                    currentSpaces = 0;
                }
            }

            Console.WriteLine($"Найбільша кількість пробілів підряд: {maxSpaces}");
            Console.ReadLine();

        }
    }
}
