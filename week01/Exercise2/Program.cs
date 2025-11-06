using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage?: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry but you don't pass.");
        }

    }
}