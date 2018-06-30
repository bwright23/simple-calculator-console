using FishingLicense.src.Models;

namespace FishingLicense.src.Logic
{
    public class OperatorSub: IOperator
    {
        double val = 0;
        public double Results {
                get {return val;} 
                set {val = value;}
        }
        public OperatorSub() {}

         public double Calculate(double num1, double num2)
        {
           Results = num1 - num2;
           return Results;
        }
    }
}