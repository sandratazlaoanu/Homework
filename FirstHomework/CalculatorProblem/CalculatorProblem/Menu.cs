using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProblem
{
    public class Menu
    {
        public static void MenuFunction()
        {
            Calculator calculator = new Calculator();

            Console.Write("First number: ");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second number: ");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Choose an operation: ");
                Console.WriteLine("1. Press A for ADD.");
                Console.WriteLine("2. Press S for SUBSTRACT.");
                Console.WriteLine("3. Press M for MULTIPLY.");
                Console.WriteLine("4. Press D for DIVIDE.");

                var userInput = Console.ReadKey();
                Console.WriteLine();

                switch (userInput.Key)
                {
                    case ConsoleKey.A:
                        
                        Console.WriteLine("The result is: " + calculator.Add(firstNumber, secondNumber));

                        break;

                    case ConsoleKey.S:
                        Console.WriteLine("The result is: " + calculator.Substract(firstNumber, secondNumber));
                        break;

                    case ConsoleKey.M:
                        Console.WriteLine("The result is: " + calculator.Multiply(firstNumber, secondNumber));
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("The result is: " + calculator.Divide(firstNumber, secondNumber));
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;

                }
            }

        }
    }
}