using System;


namespace Calculator
{
    public class Calculator
    {
        public enum Action { Add, Subtract, Multiply, Power }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x, y);

            {
                /*
               public double Power(double x, double exp){
                       if (exp == 0)
                       {
                           return 1;
                       }
                       if (exp % 2 == 0)
                       {
                           return Power(x, exp / 2) * Power(x, exp / 2);
                       }
                       else
                       {
                           if (exp > 0)
                           {
                               return Power(x, exp / 2) * Power(x, exp / 2) * x;
                           }
                           else
                           {
                               return Power(x, exp / 2) * Power(x, exp / 2) / x;
                           }
                       }

                }*/
            }
        }

        //public static void PrintCalculation(Action action, double x, double y)
        //{
        //    switch (action)
        //    {
        //        case Action.Add:
        //            Console.WriteLine("The sum of {0} and {1} is: {2}", x, y, Add(x, y));
        //            break;
        //        case Action.Subtract:
        //            Console.WriteLine("The difference of {0} and {1} is: {2}", x, y, Subtract(x, y));
        //            break;
        //        case Action.Multiply:
        //            Console.WriteLine("The product of {0} and {1} is: {2}", x, y, Multiply(x, y));
        //            break;
        //        case Action.Power:
        //            Console.WriteLine("{0} raised to the power of {1} is: {2}", x, y, Power(x, y));
        //            break;
        //    }
        //}
    }
}

