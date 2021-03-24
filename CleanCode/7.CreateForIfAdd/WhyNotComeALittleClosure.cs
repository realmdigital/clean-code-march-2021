using System;
using System.Linq;

namespace CleanCode._7.CreateForIfAdd
{
    // RATING: STRONGLY RECOMMENDED
    public class WhyNotComeALittleClosure
    {
        public void Main()
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            
            // obviously if you haven't seen these before they might be confusing, but that's part of learning
            
            var total = numbers
                .Where(number => number % 2 == 0)
                .Aggregate(0, (accumulator, number) => accumulator + number);
            Console.WriteLine($"the total is {total}");
            
            // same thing but with built in .Sum() function
            total = numbers
                .Where(number => number % 2 == 0)
                .Sum();
            Console.WriteLine($"the total is {total}");
            
            var evenNumbersAsStrings = numbers
                .Where(number => number % 2 == 0)
                .Select(x => x.ToString())
                .ToList();
            Console.WriteLine($"there are {evenNumbersAsStrings.Count} even numbers");
            
            // you can also use method references, which makes them even easier to read
            total = numbers
                .Where(IsEven)
                .Sum();
            Console.WriteLine($"the total is {total}");

        }
        
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}