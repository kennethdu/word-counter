using System;
using System.Collections.Generic;

namespace LeapYears.Models
{
    public class LeapYearChecker
    {
        private int _year;
        private string _results;
        private static List<LeapYearChecker> _instances = new List<LeapYearChecker> { };

        public LeapYearChecker(string newYear)
        {
            _year = int.Parse(newYear);
            _results = IsLeapYear(_year);
            _instances.Add(this);
        }
        public int GetYear()
        {
            return _year;
        }
        public string GetResults()
        {
            return _results;
        }
        public static List<LeapYearChecker> GetAll()
        {
            return _instances;
        }
        public string IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return _year + "is a leap year";
            }
            else if (year % 100 == 0)
            {
                return _year + "is not a leap year";
            }
            else
            {
                return _year + " is a leap year";
            }
        }
    }
}