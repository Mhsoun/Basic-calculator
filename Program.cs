using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //gathering input from user

            Console.WriteLine("Hi and welcome to the Basic calculator");
            Console.WriteLine("Enter the first number");
            _ = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please choose what operation you wanna do!");
            Console.WriteLine("if addition typ +, subtraction typ - , multiplication typ x or typ / for division");
            string operationCode = Console.ReadLine();
            Console.WriteLine("Enter the second number!");
            _ = int.TryParse(Console.ReadLine(), out int secondNumber);

            
            int result;

            if (operationCode == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine("the result is: " + result);

            }
            else if (operationCode == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine("the result is: " + result);

            }
            else if (operationCode == "x")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine("the result is: " + result);

            }
            else if (operationCode == "/")
            {
                if (secondNumber!= 0)
                {
                    result = firstNumber/ secondNumber;
                    Console.WriteLine("the result is: " + result);
                }
                else
                {
                    Console.WriteLine("you cannot divid on zero");
                }
            }
            else
            {
                Console.WriteLine("unvalid operation");
            }
        }
    }
}
