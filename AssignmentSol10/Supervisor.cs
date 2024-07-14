using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSol10
{
    public class Supervisor : Employee
    {
        public int Subordinates { get; set; }

        public Supervisor() : base()
        {
            Designation = "Supervisor";
            Subordinates = 0;
        }

        public Supervisor(string name, bool gender, DateTime birth, string address, double salary, int subordinates)
            : base(name, gender, birth, address, salary, "Supervisor", DepartmentType.IT)
        {
            Subordinates = subordinates;
        }

        public override void Accept()
        {
            base.Accept(); 

            Console.Write("Enter number of subordinates: ");
            Subordinates = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();

            Console.WriteLine($"Number of Subordinates: {Subordinates}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Number of Subordinates: {Subordinates}";
        }
    }

}
