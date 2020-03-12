using System;

namespace recreate_fizzbuzz
{
    class Program
    {
        private const int V = 100;

        static void Main(string[] args)
        {
            // TODO: tengo que agregar eso. 
            for (int i = 1; i
                < V; i++)
            {
                string res = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Fizz" : (i % 3 == 0) ? "Buzz" : i.ToString();
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
