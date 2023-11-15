using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Globalization;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SkottårKalkylator
{
    public class År
    {
        public int år { get; set; }

        public static int FåDagNummer(string dateString)
        {
            // Specify the format of the date string
            string format = "d.MMMM.yyyy";

            // Parse the string into a DateTime object
            DateTime parsedDate = DateTime.ParseExact(dateString, format, System.Globalization.CultureInfo.InvariantCulture);
           
            // Output the day of the year
            int dayOfYear = parsedDate.DayOfYear;

            return dayOfYear;
        }
        
        public static int FåVeckaNummer(string dateString)
        {
            

                string format = "d.MMMM.yyyy";

                DateTime parsedDate = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

                // Output the week of the year
                int weekOfYear = GetIso8601WeekOfYear(parsedDate);


            return weekOfYear;
           
        }

        static int GetIso8601WeekOfYear(DateTime time)
        {
            // Set the calendar to use the ISO 8601 rules for determining the week of the year
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;

            int day = (int)calendar.GetDayOfWeek(time);
            if (day is >= (int)DayOfWeek.Monday and <= (int)DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of the year
            return calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }


        public static bool ÄrSkottår(int år)
       {
        var skottår = år % 4;
        if (skottår == 0)
        {
            return true;
        }
        else
        { return false; }
       }

        public static string FåDagNamn(string dateString)
        {
            // Specify the format of the date string
            string format = "d.MMMM.yyyy";

            // Parse the string into a DateTime object
            DateTime parsedDate = DateTime.ParseExact(dateString, format, System.Globalization.CultureInfo.InvariantCulture);

            // Output the day of the year
            string dayOfWeek = parsedDate.DayOfWeek.ToString();

            return dayOfWeek;
        }
    }
}