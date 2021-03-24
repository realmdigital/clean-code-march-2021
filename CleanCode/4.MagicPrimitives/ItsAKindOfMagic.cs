using System;

namespace CleanCode._4.MagicPrimitives
{
    
    // RATING: ESSENTIAL
    public class ItsAKindOfMagic
    {
        public void Main()
        {
            var currentDayOfWeek = "Friday";
            DoSomeWork(currentDayOfWeek);
            DoSomeOtherWork(currentDayOfWeek);
            GoHomeNow(currentDayOfWeek);
        }

        private void DoSomeWork(string currentDayOfWeek)
        {
            
            if (currentDayOfWeek != "Sunday" && currentDayOfWeek != "Saturday")
            {
                Console.WriteLine("I just wrote a document");
            }
        }

        private void DoSomeOtherWork(string currentDayOfWeek)
        {
            if (currentDayOfWeek != "Sunday" && currentDayOfWeek != "Saturday")
            {
                Console.WriteLine("Does someone have a back of the production database???");
            }
        }

        private void GoHomeNow(string currentDayOfWeek)
        {
            if (currentDayOfWeek == "Sunday" || currentDayOfWeek == "Saturday")
            {
                Console.WriteLine("Why are you at work on the weekend?");
                return;
            }
            Console.WriteLine("I'm driving home");
        }
    }
}