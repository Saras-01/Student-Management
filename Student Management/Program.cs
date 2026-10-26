using System;

Console.WriteLine("================================");
Console.WriteLine("   STUDENT MANAGEMENT SYSTEM");
Console.WriteLine("================================");

Console.Write("Enter student name: ");
string name = Console.ReadLine() ?? "";

Console.Write("Enter student age: ");
string ageInput = Console.ReadLine() ?? "";

if (int.TryParse(ageInput, out int age) && age > 0)
{
    Console.WriteLine("\nStudent Registered Successfully!");
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"Student Name: {name}");
    Console.WriteLine($"Student Age: {age}");
}
else
{
    Console.WriteLine("Invalid age. Please enter a positive number.");
}
