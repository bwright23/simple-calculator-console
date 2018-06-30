namespace FishingLicense.src.Models
{
    interface IOperator
    {
        double Results {get;set;}

        double Calculate(double number1, double number2); 
    }

}