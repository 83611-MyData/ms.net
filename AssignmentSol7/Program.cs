using System;

public class Person
{
    public string Name { get; set; }
    public bool Gender { get; set; }
    public DateTime Birth { get; set; }
    public string Address { get; set; }

    public int Age => CalculateAge();

    public Person()
    {
        Name = "";
        Gender = true; // true = male || false = female
        Birth = DateTime.Today; 
        Address = "";
    }

    public Person(string name, bool gender, DateTime birth, string address)
    {
        Name = name;
        Gender = gender;
        Birth = birth;
        Address = address;
    }

    public void Accept()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();

        Console.Write("Enter gender (M/F): ");
        string genderInput = Console.ReadLine().ToUpper();
        Gender = genderInput == "M";

        Console.WriteLine("Enter birth date (YYYY-MM-DD):");
        string birthDateInput = Console.ReadLine();
        if (DateTime.TryParse(birthDateInput, out DateTime birthDate))
        {
            Birth = birthDate;
        }
        else
        {
            Console.WriteLine("Invalid date format.");
            Birth = DateTime.Today;
        }

        Console.Write("Enter address: ");
        Address = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gender: {(Gender ? "Male" : "Female")}");
        Console.WriteLine($"Birth Date: {Birth:yyyy-MM-dd}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Age: {Age}");
    }

    public int CalculateAge()
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - Birth.Year;

         return age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Gender: {(Gender ? "Male" : "Female")}, Birth Date: {Birth:yyyy-MM-dd}, Address: {Address}, Age: {Age}";
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Accept();

        Console.WriteLine("\nPerson Details:");
        person.Print();

        Console.WriteLine("\nPerson Details (ToString):");
        Console.WriteLine(person.ToString());
    }
}
