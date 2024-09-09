﻿using LINQAsignment.Models;

List<Person> people = new List<Person>();

// Accept user input for multiple instances of the Person class

while (true)

{

    Console.WriteLine("\nEnter person details or type 'exit' to finish:");

    Console.Write("Name: ");

    string name = Console.ReadLine();

    if (name.ToLower() == "exit")

        break;

    Console.Write("Age: ");

    if (!int.TryParse(Console.ReadLine(), out int age))

    {

        Console.WriteLine("Invalid age. Please enter a valid number.");

        continue;

    }

    Console.Write("Salary: ");

    if (!decimal.TryParse(Console.ReadLine(), out decimal salary))

    {

        Console.WriteLine("Invalid salary. Please enter a valid number.");

        continue;

    }

    people.Add(new Person { Name = name, Age = age, Salary = salary });

}

// Perform LINQ queries on the collection

Console.WriteLine("\nLINQ Queries:");

// Query 1: Filter based on age greater than 30

var filteredPeople = people.Where(p => p.Age > 30).ToList();

DisplayResults("People older than 30:", filteredPeople);

// Query 2: Sort by name

var sortedPeopleByName = people.OrderBy(p => p.Name).ToList();

DisplayResults("People sorted by name:", sortedPeopleByName);

// Query 3: Calculate average salary

var averageSalary = people.Average(p => p.Salary);

Console.WriteLine($"Average Salary: {averageSalary:C}");

// Query 4: Calculate total age

var totalAge = people.Sum(p => p.Age);

Console.WriteLine($"Total Age: {totalAge}");

            // Additional queries can be added based on requirements

        

        // Helper method to display results
static void DisplayResults(string heading, List<Person> people)

{

    Console.WriteLine($"\n{heading}");

    foreach (var person in people)

    {

        Console.WriteLine($"{person.Name}, Age: {person.Age}, Salary: {person.Salary:C}");

    }

}