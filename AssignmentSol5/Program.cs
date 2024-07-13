using System;

public class Date
{
    public int day { get; set; }
    public int month { get; set; }
    public int year { get; set; }

    public Date()
    {
        day = 1;
        month = 1;
        year = 2000;
    }

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public static Date CreateFromConsoleInput()
    {
        Console.Write("Enter the Date: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter the Month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the Year: ");
        int year = int.Parse(Console.ReadLine());

        return new Date(day, month, year);
    }

    public void PrintDate()
    {
        Console.WriteLine($"{day:D2}/{month:D2}/{year}");
    }

    public bool IsValid()
    {
        if (year < 1 || month < 1 || month > 12 || day < 1 || day > 31)
            return false;

        if (month == 2)
            return day <= (IsLeapYear(year) ? 29 : 28);

        if (month == 4 || month == 6 || month == 9 || month == 11)
            return day <= 30;

        return true;
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year}";
    }

    public static int DifferenceInYears(Date d1, Date d2)
    {
        return Math.Abs(d1.year - d2.year);
    }

    public static int operator -(Date d1, Date d2)
    {
        return DifferenceInYears(d1, d2);
    }
}

