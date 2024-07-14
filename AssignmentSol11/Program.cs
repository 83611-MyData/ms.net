using System;

namespace AssignmentSol11
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

            WageEmp wageEmployee = new WageEmp();
            wageEmployee.Accept();
            wageEmployee.Print();

            Console.WriteLine(wageEmployee.ToString());

        }
   
    }
}