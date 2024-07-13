using System;

struct Student
{
    private string name;
    private bool gender;    // boolean, true for male, false for female
    private int age;
    private int std;
    private char div;
    private double marks;

  
    public Student()
    {
        name = "Unknown";
        gender = true;
        age = 0;
        std = 0;
        div = 'A';
        marks = 0.0;
    }

    
    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

   
    public void AcceptDetails()
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        while (true)
        {
            Console.Write("Please enter your gender : ");
            Console.Write("syntax : M or MALE / F or FEMALE");
            string genderInput = Console.ReadLine().ToUpper();

            if (genderInput == "M" || genderInput == "MALE")
            {
                gender = true; 
                break;
            }
            else if (genderInput == "F" || genderInput == "FEMALE")
            {
                gender = false; 
                break;
            }
            else
            {
                Console.WriteLine("invalid output. please try again.");
            }
        }

        Console.Write("Please enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter your class: ");
        std = Convert.ToInt32(Console.ReadLine());

        Console.Write("Pleaase enter your section: ");
        div = Convert.ToChar(Console.ReadLine().ToUpper());

        Console.Write("PLease enter your total marks: ");
        marks = Convert.ToDouble(Console.ReadLine());
    }

    
    public void PrintDetails()
    {
        Console.WriteLine("\nFollowing are the Student Details:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Gender: {(gender ? "Male" : "Female")}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Standard: {std}");
        Console.WriteLine($"Division: {div}");
        Console.WriteLine($"Marks: {marks}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.AcceptDetails();
        student.PrintDetails();
    }
}
