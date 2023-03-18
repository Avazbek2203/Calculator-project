using System;

namespace Birinchi_dars
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.Write("Enter first number : ");
            double firstNumber;
            while (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Please enter a valid number!");
            }
            Console.Write("Choose one of them :  ");
            Console.Write("+   ");
            Console.Write("-   ");
            Console.Write("*   ");
            Console.Write("/   ");
            Console.WriteLine("%");
            char mathimaticalSign;
            while (!char.TryParse(Console.ReadLine(), out mathimaticalSign) || (mathimaticalSign != '+' && mathimaticalSign != '-' && mathimaticalSign != '*' && mathimaticalSign != '/' && mathimaticalSign != '%'))
            {
                Console.WriteLine("Please enter a valid mathematical sign!");
            }
            Console.Write("Enter second number : ");
            double secondNumber;
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Please enter a valid number!");
            }

            if (mathimaticalSign == '*')
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            }
            if (mathimaticalSign == '/')
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Number doesn't divide by zero!");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                }
            }

            if (mathimaticalSign == '+')
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            }
            if (mathimaticalSign == '-')
            {
                if (secondNumber > firstNumber)
                {
                    Console.WriteLine("Second number is greater than the first number!");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                }
            }
            if (mathimaticalSign == '%')
            {
                Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
            }

            Console.WriteLine("========================================================");

            Main(args);
        }

    }
}
