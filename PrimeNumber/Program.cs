using System;

namespace PrimeNumber
{
    class Program
    {
        static int PrimeNum(int number, int i, int count)
        {
            while(i <= 9)
            {
                i++;
                while (number % i == 0)
                {
                    if (i != number)
                    {
                        count++;
                    }
                    return PrimeNum(number, i, count);
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int count = 0;
            int i = 1;
            if (PrimeNum(number, i, count) == 0)
            {
                Console.WriteLine("It's a prime number " + number);
            }
            else
            {
                Console.WriteLine("It's a composite number " + number);
            }
        }
    }

}
