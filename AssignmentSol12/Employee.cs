using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSol12
{
    public class Employee : Person
    {
        private static int idCounter = 1;

        public int Id { get; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public DepartmentType Dept { get; set; }

        public Employee() : base()
        {
            Id = idCounter++;
            Salary = 0.0;
            Designation = "Wage";
            Dept = DepartmentType.IT; 
        }

        public Employee(string name, bool gender, DateTime birth, string address, double salary, string designation, DepartmentType dept)
            : base(name, gender, birth, address)
        {
            Id = idCounter++;
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }

        public override void Accept()
        {
            base.Accept(); 

            Console.Write("Enter salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter designation: ");
            Designation = Console.ReadLine();

            Console.Write("Enter department (HR, IT, Finance, Operations, Marketing): ");
            string deptInput = Console.ReadLine();
            if (Enum.TryParse(deptInput, true, out DepartmentType department))
            {
                Dept = department;
            }
            else
            {
                Console.WriteLine("Invalid department. Defaulting to IT.");
                Dept = DepartmentType.IT;
            }
        }

        public override void Print()
        {
            base.Print(); 

            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Department: {Dept}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Employee ID: {Id}, Salary: {Salary:C}, Designation: {Designation}, Department: {Dept}";
        }
    }

}
