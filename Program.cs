using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_PROBA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Калькулятор для новичка

            int x, b, result;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================================");
            Console.WriteLine("Введите число x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("=======================================");
            Console.WriteLine("Введите число b: ");
            b = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            while (true) 
            {
                Console.WriteLine($"Введите математический символ: \t\n + \t\n - \t\n * \t\n / \t\n");
                string Math = "+" + "-" + "*" + "/";
                Math = Console.ReadLine();

                switch (Math)
                {
                    case "+":
                        result = x + b;
                        Console.WriteLine($"Ответ: {result}");
                        break;

                    case "-":
                        result = x - b;                      
                        Console.WriteLine($"Ответ: {result}");
                        break;

                    case "*":
                        result = x * b;
                        Console.WriteLine($"Ответ: {result}");
                        break;

                    case "/":
                        result = x / b;
                        Console.WriteLine($"Ответ: {result}");
                        break;
                }

                Console.ReadLine();

            }
        }
    }
}
