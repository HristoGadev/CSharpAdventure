using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateModifiers
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }
        public string SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }

        public string FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }
        public void CalculateDates(string firstDate, string secondDate)
        {
            var date1 = firstDate.Split().Select(int.Parse).ToArray();
            var date2 = secondDate.Split().Select(int.Parse).ToArray();
            DateTime dateFirst = new DateTime(date1[0], date1[1], date1[2]);
            DateTime dateSecond = new DateTime(date2[0], date2[1], date2[2]);

            TimeSpan differ = dateFirst.Subtract(dateSecond);

            Console.WriteLine( Math.Abs(differ.TotalDays));
        }
    }
}
