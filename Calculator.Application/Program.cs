using System;

namespace Calculator.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var first = 10;
            var second = 3.5;

            Calculator.PrintCalculation(Calculator.Action.Add, first, second);
            Calculator.PrintCalculation(Calculator.Action.Subtract, first, second);
            Calculator.PrintCalculation(Calculator.Action.Multiply, first, second);
            Calculator.PrintCalculation(Calculator.Action.Power, first, second);

            Console.ReadKey();
        }
    }
}
