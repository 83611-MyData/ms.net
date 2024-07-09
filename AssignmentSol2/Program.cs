using System;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice= "n";

            do
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter your desired function: ");
                string function = Console.ReadLine();

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (function)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("division by zero is not allowed.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("invalid input. please try again");
                        continue;
                }

                Console.WriteLine($"Result: {num1} {function} {num2} = {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                userChoice = Console.ReadLine();

            } while (userChoice.ToLower() == "y");

            Console.WriteLine("Program Exiting...");
        }
    }
}
