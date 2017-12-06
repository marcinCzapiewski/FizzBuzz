using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fizz Buzz");
            Tuple<int, int> limits =  ReadLimits();

            for(int i = limits.Item1; i <= limits.Item2; i++)
            {
                string test = "";
                test += (i % 3) == 0 ? "Fizz" : "";
                test += (i % 5) == 0 ? "Buzz" : "";

                if (test == "")
                {
                    test += i;
                }

                Console.WriteLine($"{test} ");

            }

            Console.ReadKey();
        }

        private static Tuple<int, int> ReadLimits()
        {
            Console.WriteLine("Give a lower limit number: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Read an upper limit number: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            return Tuple.Create(lowerLimit, upperLimit);
        }
    }
}
