


using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express!!!!!");

            // Prompt for Package Weight
            Console.Write("Enter the Package Weight:");
            double weight = double.Parse(Console.ReadLine());

            // Check if weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express");
                return;
            }

            // Prompt for package dimensions
            Console.Write("Enter the Package Width ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter the Package Height: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Enter the Package Length:  ");
            double length = double.Parse(Console.ReadLine());

            // Calculate total dimensions
            double totalDimensions = width + height + length;

            // Check if dimensions exceed 50
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express!!!!.");
                return;
            }

            // Calculate Total package
            double product = width * height * length;
            double Total_Package = (product * weight) / 100;

            Console.WriteLine("Your shipping Total Amount is: " + "$" + Total_Package);

        }
    }
}