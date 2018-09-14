using System;
using System.Collections.Generic;

namespace LeapYears.Models
{
    public class LeapYearChecker
    {
        public int year {get; set;}
        private static List<LeapYearChecker> _year = new List<LeapYearChecker> { };

        public LeapYearChecker(string newYear)
        {
            year = int.Parse(newYear);
        }
        public static List<LeapYearChecker> GetAll()
        {
            return _year;
        }
        public void Save()
        {
            _year.Add(this);
        }
        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else
            {
                return year % 4 == 0;
            }
        }
    }
}