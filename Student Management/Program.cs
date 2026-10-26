using System;
using System.Collections.Generic;

List<string> students = new List<string>();

bool running = true;

while (running)
{
    Console.WriteLine("\n================================");
    Console.WriteLine("   STUDENT MANAGEMENT SYSTEM");
    Console.WriteLine("================================");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.Write("Enter student name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter student age: ");
            string ageInput = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(name) &&
                int.TryParse(ageInput, out int age) &&
                age > 0)
            {
                students.Add($"{name} - Age: {age}");
                Console.WriteLine("Student added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid name or age.");
            }

            break;

        case "2":
            if (students.Count == 0)
            {
                Console.WriteLine("No students registered yet.");
            }
            else
            {
                Console.WriteLine("\nRegistered Students:");

                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {students[i]}");
                }
            }

            break;

        case "3":
            running = false;
            Console.WriteLine("Exiting Student Management System.");
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}