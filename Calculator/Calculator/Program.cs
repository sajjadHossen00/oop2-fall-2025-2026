// See https://aka.ms/new-console-template for more information
using System;

class Calculator
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Select calculation method:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= 4)
            {
                Console.Write("Enter number1: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.Write("Enter number2: ");
                double number2 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = number1 + number2;
                        break;
                    case 2:
                        result = number1 - number2;
                        break;
                    case 3:
                        result = number1 * number2;
                        break;
                    case 4:
                        result = number1 / number2;
                        break;
                }

                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }

        } while (choice != 5);
    }
}


