using System;

namespace _10.NestedLoopsExercise
{
    internal class Program
    {
        static void Main()
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            string input = Console.ReadLine();
            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime = true;

                if (number == 0 || number == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
