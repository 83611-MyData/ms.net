using System;

namespace AssignmentSol5
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date 1:");
            Date date1 = Date.CreateFromConsoleInput();

            Console.WriteLine("\nEnter Date 2:");
            Date date2 = Date.CreateFromConsoleInput();

            Console.WriteLine("\nDate 1:");
            if (date1.IsValid())
            {
                date1.PrintDate();
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }

            Console.WriteLine("\nDate 2:");
            if (date2.IsValid())
            {
                date2.PrintDate();
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }

            Console.WriteLine($"\nDifference in years between date1 and date2: {Date.DifferenceInYears(date1, date2)} years");
        }
    }
}
