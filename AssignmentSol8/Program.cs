using System;

namespace AssignmentSol8
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.Accept();

            Console.WriteLine("\nEmployee Details:");
            employee.Print();

            Console.WriteLine("\nEmployee Details (ToString):");
            Console.WriteLine(employee.ToString());
        }
    }
}