using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            while (true)
            {
                Console.WriteLine(context.Screen());
                Console.Write(">>> ");
                var key = Console.ReadKey().KeyChar.ToString();
                switch (key)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9": context.Digit(key); break;
                    case "c":
                    case "C": context.Clear(); break;
                    case "+":
                    case "-":
                    case "/":
                    case "*": context.Operation(key); break;
                    case "=": context.Equal(); break;
                    case "q": return;
                }
                Console.WriteLine();
            }
        }
    }
}
