
namespace TestHandIn2EquivalenceBoundary.Services
{
    public class GetDaysInMonthClass
    {
        /// <summary>
        /// Calculates the number of days in month.
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns>Number of days in month that year or -1 if input values are invalid</returns>
        public int getNumberOfDaysInMonth(int month, int year)
        {
            //check for invalid inputs and return -1 if invalid
            if      (month < 1 || month > 12)               { return -1; }
            if      (year < 1 || year > int.MaxValue -1)    { return -1; }

            //check for leap year and february and return days accordingly
            bool leapYear = isLeapYear(year);
            if      (month == 2 && leapYear)                { return 29; }
            else if (month == 2 && !leapYear)               { return 28; }

            //else if months jan, march, may, july, aug, oct or dec return 31
            //else if months apr, june, sep or nov return 30
            if      (month < 8 && month % 2 != 0)           { return 31; }
            else if (month < 8 && month % 2 == 0)           { return 30; }
            else if (month % 2 == 0)                        { return 31; }
            else                                            { return 30; }
        }

        /// <summary>
        /// Check for leap year.
        /// 
        /// If the year is dividable by 4 its a leap year,
        /// if it is dividable by 100 but not 400 then it is not a leap year,
        /// all other cases are not leap years.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Return true if leapyear and false if not</returns>
        private bool isLeapYear(int year)
        {
            if          (year % 400 == 0)                   { return true; }
            else if     (year % 4 == 0 && year % 100 != 0)  { return true; }
            else                                            { return false; }
        }
    }
}
