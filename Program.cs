
using System;
using sdc1_knowledge_check_2;

class Program
{ 
    private static void Main()
    {
    Console.WriteLine("Welcome to the Soup Store!");
    Console.WriteLine ("How many Menu Items do you want to add? ");
    var numberOfRecords = int.Parse(Console.ReadLine());

    var recordList = new List<Soup>();
    for (int i = 0; i < numberOfRecords; i++)
        {
        // In this loop, populate the object's properties using Console.ReadLine()
        var soup = new Soup();

        Console.WriteLine("Enter the value for Soup Name");
        soup.Name = Console.ReadLine();
        Console.WriteLine("Enter the value for Price");
        soup.Price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for Description");
        soup.Description = Console.ReadLine();
        Console.WriteLine("Enter the value for Broth");
        soup.Broth = Console.ReadLine();
        Console.WriteLine("Enter the value for Protien");
        soup.Protien = Console.ReadLine();
        Console.WriteLine("Enter the value for Vegetable");
        soup.Vegetable = Console.ReadLine();
        
        Console.WriteLine("You've added " + soup.Name + " successfully!");
        Console.WriteLine("Price: $" + soup.Price);
        Console.WriteLine("Broth: " + soup.Broth);
        Console.WriteLine("Protien: " + soup.Protien);
        Console.WriteLine("Vegetable: " + soup.Vegetable);


            recordList.Add(soup);
        }
        // Print out the list of records using Console.WriteLine()
    }
    

}
