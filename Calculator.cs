using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        public void Run()
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                double num1 = ReadNumber("Enter first number: ");
                double num2 = ReadNumber("Enter second number: ");

                char operation = ReadOperation();

                if (operation == '/' && num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    continue;
                }

                double result = Calculate(num1, num2, operation);

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                string? answer = Console.ReadLine();

                continueCalculating = answer?.ToLower() == "y";
            }
        }

        private double ReadNumber(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private char ReadOperation()
        {
            while (true)
            {
                Console.Write("Enter operation (+, -, *, /): ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) && input.Length == 1)
                {
                    char operation = input[0];

                    if (operation == '+' ||
                        operation == '-' ||
                        operation == '*' ||
                        operation == '/')
                    {
                        return operation;
                    }
                }

                Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
            }
        }

        private double Calculate(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return Add(num1, num2);

                case '-':
                    return Subtract(num1, num2);

                case '*':
                    return Multiply(num1, num2);

                case '/':
                    return Divide(num1, num2);

                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }

        private double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }

}

