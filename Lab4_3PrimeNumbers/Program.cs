using System;

namespace Lab4_3PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!\n\nThis application will find you any prime, in order, from first prime number on.\n");

            Console.Write("Which prime number are you looking for? ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe number {index} prime is {PrimeNumbers.GetPrime(index)}");
        }
    }

    public class PrimeNumbers
    {
        // METHODS
        public static int GetPrime(int n)
        {
            int counter = 0;
            int currentNumber = 2;

            while (counter < n)
            {
                if (IsPrimeNumber(currentNumber))
                {
                    counter++;
                }
                currentNumber++;
            }

            currentNumber--;
            return currentNumber;
        }

        public static bool IsPrimeNumber(int _num)
        {
            bool isPrime = true;

            for (double i = _num - 1; i > 1; i--)
            {
                double result = _num / i;
                if (result % 1 == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
