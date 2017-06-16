using System;
using FizzBuzz.Extensions;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            bool multipleOfThree, multipleOfFive;

            for (var i = 1; i <= 100; i++)
            {
                multipleOfThree = i.MultipleOf(3);
                multipleOfFive = i.MultipleOf(5);

                if (multipleOfThree && multipleOfFive)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (multipleOfThree)
                {
                    Console.WriteLine("fizz");
                }
                else if (multipleOfFive)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }                
            }
            Console.ReadLine();
        }
    }
}
