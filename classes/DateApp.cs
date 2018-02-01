using System;
using static System.Console;

namespace DateApp
{
    class DateApp
    {
        static void Main(string[] args)
        {
            string tempMonthName, inMonth, inDay, inYear;
            int tempMonth, tempDay, tempYear;

            WriteLine("What is the name of the month?");
            tempMonthName = ReadLine();

            WriteLine();

            WriteLine("What is the two-digit day?");
            inDay = ReadLine();
            tempDay = int.Parse(inDay);

            WriteLine();

            WriteLine("What is the four-digit year?");
            inYear = ReadLine();
            tempYear = int.Parse(inYear);

            WriteLine();

            Date firstStyle = new Date(tempMonthName, tempDay, tempYear);

            WriteLine(firstStyle.RetNameDate());

            WriteLine();

            WriteLine("What is the two-digit month?");
            inMonth = ReadLine();
            tempMonth = int.Parse(inMonth);

            WriteLine();

            Date secondStyle = new Date(tempMonth, tempDay, tempYear);

            WriteLine(secondStyle.ToString());

            ReadKey();

        }
    }
}
