using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func<int> fibo = Fibonacci(), prime = Primes(), nat = Naturals();
            Func<int> fibo = Fibonacci(), nat = Naturals();

            Console.WriteLine("--------Fibonacci--------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fibo());
            }

            Console.WriteLine("\n--------Primes--------");
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(prime());
            // }
            Primes();
            
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

        static void Primes()
        {
            //variable que contiene el numero que se está probando
        int n = 2;
        //variable que contiene el total de numeros primos encontrados
        int total = 1;

        //iterar mientras el total de numeros primos no se mayor a 100
        while(total <= 10){

            //variable que indica si un numero es primo o no
            bool esPrimo = true;

            //se divide el numero (n) entre todos los numeros anterios a el
            //si el modulo de la division es 0 significa que el numero no es primo
            //y se marca la variable esPrimo = false y se termina el ciclo for
            for (int i = 2; i < n; i++) {
                if(n % i == 0)
                {
                    esPrimo = false;
                    break;
                }

            }

            //si despues de ejecutar el ciclo for la variable esPrimo sigue
            //teniendo un valor true entonces se imprime el numero y se incrementa
            // el contador de numeros encontrados total++
            if(esPrimo)
            {
             Console.WriteLine(n);
              total++;
            }
            //se incrementa para evaluar el siguiente número
            n++;
        }
        }

        static Func<int> Naturals()
        {
            int i = 0;
            return () => ++i;
        }
    }
}
