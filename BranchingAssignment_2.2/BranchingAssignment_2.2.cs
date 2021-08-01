using System;  
public class Practical_Assignment
{  
    static void Main(string[] args)
    {
        Console.WriteLine("Please write the grade level of the exam (A, B, C, D, E or F):");
        char gradeLevel = Char.Parse(Console.ReadLine());
        switch (gradeLevel)
        {
            case 'A':
            Console.WriteLine("Perfect! You are so clever!");
            break;
            case 'B':
            Console.WriteLine("Perfect! You are so clever!");
            break;
            case 'C':
            Console.WriteLine("Good! But You can do better!");
            break;
            case 'D':
            Console.WriteLine("It is not good! You should study!");
            break;
            case 'E':
            Console.WriteLine("It is not good! You should study!");
            break;
            case 'F':
            Console.WriteLine("Fail! You need to repeat the exam!");
            break;
            default:
            Console.WriteLine("Wrong input!");
            break;
        }
    }
}