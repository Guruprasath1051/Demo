using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basic_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Csharp Basic Program");

            Console.WriteLine("Please enter the day number between1 to 7");
            int day = Convert.ToInt32(Console.ReadLine());
            WeekDay.FindDayWhichFallOnWeek(day);

            Console.WriteLine("Please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator(first, second);
            calculator.Addition();
            calculator.Substraction();
            calculator.Multiplication();
            calculator.Division();
            Console.ReadLine();
        }
    }
}
