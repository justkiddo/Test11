using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_11.Classes
{
    internal class DateTimeExtension
    {
        
        public string Passed()
        {
            DateTime voteTime = new DateTime(1, 1, 1, 0, 0, 0);
            TimeSpan TimePassed = DateTime.Now - voteTime;
            string passed = $"День {DateTime.Now.Day} месяца {DateTime.Now.ToString("MMMM")} года {DateTime.Now.Year} от сотворения мира";
            Console.WriteLine(passed);
            return passed;
        }

    }
}
