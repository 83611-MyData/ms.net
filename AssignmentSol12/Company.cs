using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSol12
{

    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public LinkedList<Employee> EmpList { get; private set; }
        public double SalaryExpense { get; private set; }

        public Company()
        {
            Name = "";
            Address = "";
            EmpList = new LinkedList<Employee>();
            SalaryExpense = 0.0;
        }

        public Company(string name, string address)
        {
            Name = name;
            Address = address;
            EmpList = new LinkedList<Employee>();
            SalaryExpense = 0.0;
        }

        public void Accept()
        {
            Console.Write("Enter company name: ");
            Name = Console.ReadLine();

            Console.Write("Enter company address: ");
            Address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Company Name: {Name}");
            Console.WriteLine($"Company Address: {Address}");
            Console.WriteLine($"Total Salary Expense: {SalaryExpense:C}");
            PrintEmployees();
        }

        public void CalculateSalaryExpense()
        {
            SalaryExpense = 0.0;
            foreach (var emp in EmpList)
            {
                SalaryExpense += emp.Salary;
            }
        }

        public void AddEmployee(Employee e)
        {
            EmpList.AddLast(e);
            CalculateSalaryExpense();
        }

        public bool RemoveEmployee(int id)
        {
            var node = FindEmployee(id);
            if (node != null)
            {
                EmpList.Remove(node);
                CalculateSalaryExpense();
                return true;
            }
            return false;
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            var current = EmpList.First;
            while (current != null)
            {
                if (current.Value.Id == id)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public override string ToString()
        {
            return $"Company Name: {Name}, Company Address: {Address}, Total Salary Expense: {SalaryExpense:C}";
        }

        
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var emp in EmpList)
            {
                Console.WriteLine(emp);
            }
        }
    }

}
