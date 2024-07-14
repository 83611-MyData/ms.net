using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSol11
{
   
    public class WageEmp : Employee
    {
        public int Hours { get; set; }
        public int Rate { get; set; }

        
        public WageEmp() : base()
        {
            Designation = "Wage";
            Hours = 0;
            Rate = 0;
        }

        
        public WageEmp(string name, bool gender, DateTime birth, string address, double salary, int hours, int rate, DepartmentType dept)
            : base(name, gender, birth, address, salary, "Wage", dept)
        {
            Hours = hours;
            Rate = rate;
        }

        public override void Accept()
        {
            base.Accept(); 
            Console.Write("Enter hours worked: ");
            Hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter hourly rate: ");
            Rate = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print(); 

            Console.WriteLine($"Hours Worked: {Hours}");
            Console.WriteLine($"Hourly Rate: {Rate:C}");
        }

        
        public override string ToString()
        {
            return base.ToString() + $", Hours Worked: {Hours}, Hourly Rate: {Rate:C}";
        }
    }

}

