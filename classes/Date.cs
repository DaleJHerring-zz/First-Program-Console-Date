using System;


namespace DateApp
{
    class Date
    {
        //private fields
        private string monthName;
        private int month;
        private int day;
        private int year;
       
        //constructors
        public Date()
        {
        }

        public Date(string tempMonthName, int tempDay, int tempYear)
        {
            monthName = tempMonthName;
            day = tempDay;
            year = tempYear;
        }

        public Date(int tempMonth, int tempDay, int tempYear)
        {
            month = tempMonth;
            day = tempDay;
            year = tempYear;
        }

        //properties
        public string MonthName
        {
            get
            {
                return monthName;
            }
            set
            {
                monthName = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        //method to return date with month name format
        public string RetNameDate()
        {
            return monthName + " " + day + "," + year;
        }

        //overridden string method to return date with slash format
        public override string ToString()
        {
            return month.ToString() + "/" + day.ToString() + "/" + year.ToString();
        }

    }
}
