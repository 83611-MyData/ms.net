using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSol9
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }

   
        public Manager() : base()
        {
            Designation = "Manager";
            Bonus = 0.0;
        }

   
        public Manager(string name, bool gender, DateTime birth, string address, double salary, double bonus)
            : base(name, gender, birth, address, salary, "Manager", DepartmentType.IT)
        {
            Bonus = bonus;
        }

      
        public override void Accept()
        {
            base.Accept(); 

            Console.Write("Enter bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }

       
        public override void Print()
        {
            base.Print();

            Console.WriteLine($"Bonus: {Bonus:C}");
        }

       
        public override string ToString()
        {
            return $"{base.ToString()}, Bonus: {Bonus:C}";
        }
    }

}
