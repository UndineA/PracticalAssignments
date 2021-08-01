using System;  
public class Practical_Assignment
{  
    static void Main(string[] args)
    {
        Console.WriteLine("Please write the day number (1-7):");
        int dayNumber = Int32.Parse(Console.ReadLine());
        switch (dayNumber)
        {
            case 1:
            Console.WriteLine("It is a working day!");
            break;
            case 2:
            Console.WriteLine("It is a working day!");
            break;
            case 3:
            Console.WriteLine("It is a working day!");
            break;
            case 4:
            Console.WriteLine("It is a working day!");
            break;
            case 5:
            Console.WriteLine("It is a working day!");
            break;
            case 6:
            Console.WriteLine("It is a holiday!");
            break;
            case 7:
            Console.WriteLine("It is a holiday!");
            break;
            default:
            Console.WriteLine("Wrong input!");
            break;
        }
    }
}