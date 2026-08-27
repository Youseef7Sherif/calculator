using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator {
            public void Run()
            {
                bool continueCalculating = true;

                while (continueCalculating)
                {
                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter operation (+, -, *, /): ");
                    char operation = Convert.ToChar(Console.ReadLine());

                    double result;

                    switch (operation)
                    {
                        case '+':
                            result = Add(num1, num2);
                            break;

                        case '-':
                            result = Subtract(num1, num2);
                            break;

                        case '*':
                            result = Multiply(num1, num2);
                            break;

                        case '/':
                            result = Divide(num1, num2);
                            break;

                        default:
                            Console.WriteLine("Invalid operation.");
                            continue;
                    }

                    Console.WriteLine($"Result: {result}");

                    Console.Write("Do you want to perform another calculation? (y/n): ");
                    string? answer = Console.ReadLine();

                    continueCalculating = answer?.ToLower() == "y";
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

