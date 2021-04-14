using System.Collections.Generic;
using System.Linq;

namespace CleanCode._0.Naming
{
    // RATING: ESSENTIAL
    public class WhatsInAName : IRunnable
    {
        public void Run()
        {
            // method/function names. use them in sentences. naming is actually super easy if you take time to train yourself
            // if you can't use them in a sentence or using them in a sentence causes it to become complicated/confusing, then it is a bad name

            // bad examples
            var invoice = new Order();
            var list = new List<Order>();

            // Do not use faux abbreviations/shortened words
            var ord = new Order();
            var img = new Image();
            var num = 123;

            // too clever
            var school = new List<Fish>();

            // good examples
            var order = new Order();
            var orders = new List<Order>();
            var people = new List<Person>(); // var persons would probably be fine too
            var schoolOfFish = new List<Fish>(); //this name removes ambiguity
        }

    }

    public record Order;

    public record Image;

    public record Fish;

    public record Person;
}