using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> fibo = Fibonacci(), nat = Naturals();

            Console.WriteLine("--------Fibonacci--------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fibo());
            }

            Console.WriteLine("\n--------Primes--------");
            int max = 50;
            bool[] isPrime = Primes(max);
            for (int i = 2; i < max; i++)
                if (isPrime[i]) Console.WriteLine(i);
            
            Console.WriteLine("\n--------Naturals--------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nat());
            }
        }

        static Func<int> Fibonacci()
        {
            int num1 = 0, num2 = 1, result;

            return () => {
                result = num1;
                num1 = num1 + num2;
                num2 = result;
                return result;
            };
        }

        static bool[] Primes(int max)
        {
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            for (int i = 2; i <= max; i++)
            {
                if (is_prime[i])
                {
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }

        static Func<int> Naturals()
        {
            int i = 0;
            return () => ++i;
        }
    }
}
