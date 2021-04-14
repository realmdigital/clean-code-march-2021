using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode._5.OneDotPerLine
{
    // RATING: STRONGLY RECOMMENDED
    public class ConnectTheDots 
    {
        public void Run()
        {
           var person = new Person("Bob", new (new Country("South Africa")));
           
            // dont multi line for things that change types/context
            // adds additional load to figuring out what is what
            var countryName = person.Address.Country.Name;
            Console.WriteLine($"They live in {countryName}");

            // rather
            var address = person.Address;
            var country = address.Country;
            Console.WriteLine($"They live in {country.Name}");

            // this is fine
            var firstName = person.FirstName.Trim().ToUpper();
            // dont do this
            var firstNames = person.FirstName.Trim().ToUpper().Split(" ");

            // this still counts as one line
            firstNames = person.FirstName
                .Trim()
                .ToUpper()
                .Split(" ");

            //linq is fine though
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            var evenNumbers = numbers
                .Where(IsEven)
                .Select(MultiplyByTwo)
                .ToList();
        }
        
        private int MultiplyByTwo(int number)
        {
            return number * 2;
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public record Person(string FirstName, Address Address);

        public record Address(Country Country);

        public record Country(string Name);
    }
}