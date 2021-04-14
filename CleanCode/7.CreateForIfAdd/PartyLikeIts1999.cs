using System;
using System.Collections.Generic;

namespace CleanCode._7.CreateForIfAdd
{
    // RATING: STRONGLY RECOMMENDED
    public class PartyLikeIts1999 : IRunnable
    {
        public void Run()
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            var total = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }
            Console.WriteLine($"the total is {total}");

            var evenNumbersAsStrings = new List<string>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbersAsStrings.Add(number.ToString());
                }
            }
            Console.WriteLine($"there are {evenNumbersAsStrings.Count} even numbers");
        }
    }
}