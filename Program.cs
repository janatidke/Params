using System;

namespace Params
{
    class Program
    {
        class Calculator
        {

            public int addition(params int[] lst)
            {
                int total = 0;
                foreach (int num in lst)
                {

                    total += num;
                }
                return total;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Calculator Demo");
                Calculator calc = new Calculator();
                Console.WriteLine(calc.addition(10, 20, 30));
                Console.WriteLine(calc.addition(23, 16));
                Console.WriteLine(calc.addition(12, 40));
                
            }
        }
    }
}