//Write a C# program that acts as a simple calculator in the command prompt. The program should take two numbers and an
//operator (+, -, *, /) as input and display the result.

using System;

class Easy1
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is undefined.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                return;
        }

        Console.WriteLine(result);
    }
}