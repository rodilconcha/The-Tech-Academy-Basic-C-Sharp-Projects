﻿
using System;

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the equality operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2))
            return true;

        if (emp1 is null || emp2 is null)
            return false;

        return emp1.Id == emp2.Id;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects
        Employee emp1 = new Employee { Id = 1, FirstName = "George", LastName = "Flamming" };
        Employee emp2 = new Employee { Id = 2, FirstName = "James", LastName = "Bond" };

        // Compare using overloaded operators
        Console.WriteLine($"They Are emp1 and emp2 equal?  {emp1 == emp2}");
    }
}