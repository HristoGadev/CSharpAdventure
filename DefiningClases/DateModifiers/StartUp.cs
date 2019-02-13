using System;

namespace DateModifiers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            DateModifier date = new DateModifier(firstDate, secondDate);
            date.CalculateDates(firstDate,secondDate);
        }
    }
}
