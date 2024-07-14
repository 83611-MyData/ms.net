using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSol12
{
    using System;

    class Tester
    {
        static void Main(string[] args)
        {
        
            Company myCompany = new Company();
            myCompany.Accept();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Print Company Details");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployeeToCompany(myCompany);
                        break;
                    case 2:
                        RemoveEmployeeFromCompany(myCompany);
                        break;
                    case 3:
                        myCompany.Print();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployeeToCompany(Company company)
        {
            Console.WriteLine("\nEnter Employee Details:");

            Employee newEmployee = new Employee();
            newEmployee.Accept();

            company.AddEmployee(newEmployee);
            Console.WriteLine("Employee added successfully.");
        }

        static void RemoveEmployeeFromCompany(Company company)
        {
            Console.Write("\nEnter Employee ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            if (company.RemoveEmployee(id))
            {
                Console.WriteLine($"Removed employee with ID {id}.");
            }
            else
            {
                Console.WriteLine($"Employee with ID {id} not found.");
            }
        }
    }

}
