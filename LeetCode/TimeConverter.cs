using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TimeConverter
    {
        static void Main(string[] args)
        {
            /*Given a time in -hour AM/PM format, convert it to military (24-hour) time.

            Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
            - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

            Example
            s = '12:01:00PM'

            Return '12:01:00'.
            s = '12:01:00AM'

            Return '00:01:00'.

            Function Description

            Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

            timeConversion has the following parameter(s):

            string s: a time in  hour format
            Returns

            string: the time in  hour format
            Input Format

            A single string  that represents a time in -hour clock format (i.e.:  or ).

            Constraints

            All input times are valid
            Sample Input

            07:05:45PM
            Sample Output

            19:05:45*/

            Console.WriteLine(timeConversion("12:45:54PM"));

        }

        public static string timeConversion(string s)
        {

            string ampm = s.Substring(s.Length - 2, 2);
            s = s.Remove(s.Length - 2);
            int hour = int.Parse(s.Substring(0, 2));
            if (hour == 12)
            {
                if (ampm == "AM")
                {
                    return $"00{s.Substring(2)}";
                }
                return s;
            }
            if (ampm == "AM")
            {
                return s;
            }
            hour += 12;
            return $"{hour}{s.Substring(2)}";


            //I've now encountered this a couple times.  The solution below is from the first time through.


            //string ampm = s.Substring(s.Length -2, 2);
            //s = s.Remove(s.Length - 2);
            //int hour = int.Parse(s.Substring(0, 2));
            //string newHour = "";

            ////s = s.Remove(0, 2);
            //if (hour <= 12 && s.Length == 8 && (ampm == "AM" || ampm == "PM"))
            //{
            //    if (ampm == "AM")
            //    {
            //        if (s.Substring(0, 2) == "12")
            //        {
            //            //s = string.Concat("00", s.AsSpan(3, s.Length));
            //            newHour = "00";
            //        }
            //        else
            //        {
            //            newHour = hour.ToString();
            //            if(newHour.Length == 1)
            //            {
            //                newHour = $"0{newHour}";
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (hour < 12)
            //        {
            //            hour += 12;
            //        }
            //        newHour = hour.ToString();
            //    }
            //    return newHour + s.Substring(2, s.Length-2);
            //}
            //return "Invalid Time";

        }
    }
}
