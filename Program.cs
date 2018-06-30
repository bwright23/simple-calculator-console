using System;
using FishingLicense;
using FishingLicense.src;

namespace FishingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            double string1;
            double string2;

            Console.WriteLine("Enter two numbers and press enter");
            string[] strings = Console.ReadLine().Split(' ');

            string1 = Double.Parse(strings[0]);
            string2 = Double.Parse(strings[1]);
            Console.WriteLine("You entered {0} and {1}", string1,string2);

            src.Models.IOperator add = src.CalculateFactory.CreateInstance<src.Logic.OperatorAdd>();
            add.Calculate(string1, string2);
            Console.WriteLine("Addition: " + add.Results);

            src.Models.IOperator minus = src.CalculateFactory.CreateInstance<src.Logic.OperatorSub>();
            minus.Calculate(add.Results, 5);
            Console.WriteLine("Subtraction: " + minus.Results);

            src.Models.IOperator multiply = src.CalculateFactory.CreateInstance<src.Logic.OperatorMultiply>();
            multiply.Calculate(minus.Results, add.Results);
            Console.WriteLine("Muliplication: " + multiply.Results);
            
        }
    }
}
