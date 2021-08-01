using System;  
public class Practical_Assignment
{  
    static void Main(string[] args)
    {  
        /*
        int day = 3;
        int month = 5;
        int year = 2021;
        if ((day >= 1) && (day <= 31) && (month >= 1) && (month <= 12) && (year >= 1) && (year <= 2021))
            Console.WriteLine(year + "/" + month + "/" + day);
        else
            Console.WriteLine("The date is incorrect!"); 
        */
        Console.WriteLine("Please write the day number:");
        int day = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please write the month number:");
        int month = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please write the year number:");
        int year = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please select the date formatting. 1 - YYYY/MM/DD, 2 - YYYY.MM.DD:");
        int dateFormat = Int32.Parse(Console.ReadLine());
        if ((day >= 1) && (day <= 31) && (month >= 1) && (month <= 12) && (year >= 1) && (year <= 2021))
        {
            if (dateFormat == 1)
            Console.WriteLine("Your date is " + year + "/" + month + "/" + day);
            else if (dateFormat == 2)
            Console.WriteLine("Your date is " + year + "." + month + "." + day);
        }
        else
            Console.WriteLine("The date is incorrect!");
    }  
} 
