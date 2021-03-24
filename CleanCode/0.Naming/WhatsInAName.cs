using System.Collections.Generic;

namespace CleanCode._0.Naming
{
    // RATING: ESSENTIAL
    public class WhatsInAName
    {
        
        public void Main()
        {
            // bad examples
            var invoice = new Order();
            var list = new List<Order>();
            
            // Do not use faux abbreviations/shortened words
            var ord = new Order();
            var img = new Image();
            var num = 123;
            
            // too clever
            var school  = new List<Fish>();
            
            // good examples
            var order = new Order();
            var orders = new List<Order>();
            var people = new List<Person>(); // var persons would probably be fine too
            var schoolOfFish  = new List<Fish>(); //this name removes ambiguity
        }
    }

    public record Order;
    public record Image;
    public record Fish;
    public record Person;
}