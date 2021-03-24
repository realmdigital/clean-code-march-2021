using System;
using System.Linq;

namespace CleanCode._2.DontUseElseKeyword
{
    // RATING: STRONGLY RECOMMENDED
    public class ProcessEvenNumbers
    {
        public void Main()
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            foreach (var number in numbers)
            {
                if (IsEven(number))
                {
                    Console.WriteLine($"{number} is even");
                    // so some things
                    // so some things
                    // so some things
                    // so some things
                    // so some things
                    // so some things
                }
                else
                {
                    Console.WriteLine($"{number} is odd, I am ignoring it");
                }
            }
        }
        
        private bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}