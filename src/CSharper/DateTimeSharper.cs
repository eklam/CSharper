using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharper
{
    public static class DateTimeSharper
    {
        /// <summary>
        /// Lets you easily figure out ifdateTime holds a date value that is a weekend.
        /// </summary>
        /// <param name="date">The date to be verified</param>
        /// <returns>true if the date is Saturday or Sunday; false otherwise</returns>
        /// <see cref="http://extensionmethod.net/csharp/datetime/isweekend"/>
        public static bool IsWeekend(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
