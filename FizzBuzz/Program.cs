using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string fizzBuzz;

            for (int number = 1; number <= 100; number++)
            {
                fizzBuzz = null;

                if (number % 3 == 0)
                {
                    fizzBuzz += "Fizz";
                }
                if (number % 5 == 0)
                {
                    fizzBuzz += "Buzz";
                }
                Console.WriteLine(fizzBuzz ?? number.ToString());
            }
            Console.ReadKey();
        }
    }
}
