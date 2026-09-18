using System;

class Student
{
    // Data members
    public string name;
    public int rollNo;

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Roll Number: " + rollNo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of Student class
        Student s = new Student();

        s.name = "Vizhi";
        s.rollNo = 101;

        // Display heading
        Console.WriteLine("Student Details");
        Console.WriteLine("----------------");

        // Call the Display method
        s.Display();

        // Hold the console window
        Console.ReadLine();
    }
}