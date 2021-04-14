using System;
using System.Linq;
using System.Net;

namespace CleanCode._2.DontUseElseKeyword
{
    // RATING: STRONGLY RECOMMENDED
    public class ProcessEvenNumbers : IRunnable
    {
        public void Run()
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            foreach (var number in numbers)
            {
                if (!IsEven(number))
                {
                   continue;
                }
                Console.WriteLine($"{number} is even");
                // so some things
                // so some things
                // so some things
                // so some things
                // so some things
                // so some things
                
            }

            
        }
        
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}