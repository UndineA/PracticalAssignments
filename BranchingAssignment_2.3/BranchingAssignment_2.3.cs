using System;  
public class Practical_Assignment
{  
    static void Main(string[] args)
    {
        Console.WriteLine("Please write the first number:");
        double firstNumber = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please write the second number:");
        double secondNumber = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please write the operator (+ - sum both elements; - - do subtraction; / - do dividing; * - do multiplication; % - get remainder when the first element is divided by the second element; p - print out both elements; b - verify which element is bigger; s - verify which element is smaller):");
        char operatorChoice = Char.Parse(Console.ReadLine());
        switch (operatorChoice)
        {
            case '+':
            Console.WriteLine("The result: " + (firstNumber + secondNumber));
            break;
            case '-':
            Console.WriteLine("The result: " + (firstNumber - secondNumber));
            break;
            case '/':
            Console.WriteLine("The result: " + (firstNumber / secondNumber));
            break;
            case '*':
            Console.WriteLine("The result: " + (firstNumber * secondNumber));
            break;
            case '%':
            Console.WriteLine("The result: " + (firstNumber % secondNumber));
            break;
            case 'p':
            Console.WriteLine("The result: " + firstNumber + " and " + secondNumber);
            break;
            case 'b':
            Console.WriteLine("The result: " + Math.Max(firstNumber, secondNumber));
            break;
            case 's':
            Console.WriteLine("The result: " + Math.Min(firstNumber, secondNumber));
            break;
            default:
            Console.WriteLine("Wrong input!");
            break;
        }
    }
}