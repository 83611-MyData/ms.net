using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSol11
{
        public class Person
        {
    
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Birth { get; set; }
        public string Address { get; set; }

        public int Age => CalculateAge(Birth);

        public Person()
        {
            Name = " ";
            Gender = true; // true = male || false = female
            Birth = DateTime.MinValue;
            Address = " ";
        }

        public Person(string name, bool gender, DateTime birth, string address)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            Address = address;
        }

        public virtual void Accept()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter gender (M/F): ");
            Gender = Console.ReadLine().ToUpper() == "M";

            Console.Write("Enter birth date (YYYY-MM-DD): ");
            Birth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter address: ");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {(Gender ? "Male" : "Female")}");
            Console.WriteLine($"Birth Date: {Birth:yyyy-MM-dd}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Age: {Age}");
        }

   
        public static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }


        public override string ToString()
        {
            return $"Name: {Name}, Gender: {(Gender ? "Male" : "Female")}, Birth Date: {Birth:yyyy-mm-dd}, Address: {Address}, Age: {Age}";
        }
    }

}

