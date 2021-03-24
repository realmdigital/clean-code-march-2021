using System;

namespace CleanCode._1.OnlyOneLevelOfIndentationPerMethod
{
    // RATING: ESSENTIAL
    public class PyramidOfDoom
    {
        public void Main()
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                     if (number >= 6)
                     {
                         Console.WriteLine($"{number} is even and greater than 6");
                     }
                }
            }
        }
    }
}