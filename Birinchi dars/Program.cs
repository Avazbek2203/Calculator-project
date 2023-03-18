using System;

namespace Birinchi_dars
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.Write("Enter first number : ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Please enter a valid number!");
            }
            Console.Write("Choose one of them :  ");
            Console.Write("+   ");
            Console.Write("-   ");
            Console.Write("*   ");
            Console.Write("/   ");
            Console.WriteLine("%");
            char b;
            while (!char.TryParse(Console.ReadLine(), out b) || (b != '+' && b != '-' && b != '*' && b != '/' && b != '%'))
            {
                Console.WriteLine("Please enter a valid mathematical sign!");
            }
            Console.Write("Enter second number : ");
            double c;
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Please enter a valid number!");
            }

            if (b == '*')
            {
                Console.WriteLine($"{a} * {c} = {a * c}");
            }
            if (b == '/')
            {
                if (c == 0)
                {
                    Console.WriteLine("Number doesn't divide by zero!");
                }
                else
                {
                    Console.WriteLine($"{a} / {c} = {a / c}");
                }
            }

            if (b == '+')
            {
                Console.WriteLine($"{a} + {c} = {a + c}");
            }
            if (b == '-')
            {
                if (c > a)
                {
                    Console.WriteLine("Second number is greater than the first number!");
                }
                else
                {
                    Console.WriteLine($"{a} - {c} = {a - c}");
                }
            }
            if (b == '%')
            {
                Console.WriteLine($"{a} % {c} = {a % c}");
            }

            Console.WriteLine("========================================================");

            Main(args);
        }

    }
}
