using System;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = " ";

            do
            {
                Console.Clear();
                Console.WriteLine("Basic Calculator Program using do-while loop");
                Console.WriteLine("Select a function:");
                Console.WriteLine("Enter 1. for Addition");
                Console.WriteLine("Enter 2. for Subtraction");
                Console.WriteLine("Enter 3. for Multiplication ");
                Console.WriteLine("Enter 4. for Division ");
                Console.WriteLine("Enter 5. to Exit");

                Console.Write("Enter your choice (1-5): ");
                userChoice = Console.ReadLine();

                if (userChoice == "5")
                {
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (userChoice)
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("invalid choice. try again");
                        break;
                }

                Console.Write("Want to perform another calculation? Enter-(y/n): ");
                userChoice = Console.ReadLine();

            } while (userChoice.ToLower() == "y");

            Console.WriteLine("program exiting...");
        }
    }
}
