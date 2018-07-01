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
            
            BuildLicense();


            Console.WriteLine(new string('*',25));
            Console.WriteLine("Enter your age:");
            var age = Console.ReadLine();
            src.Models.FishermanBase person = src.CalculateFactory.CreateInstance<src.Models.FishermanBase>();
            person.Name = "Bwright23";
            person.StartingAge = int.Parse(age);

            Console.WriteLine("Hello {0} you're age is {1}", person.Name, person.StartingAge);
        }

        static void BuildLicense()
        {

        src.Models.aLicenseComponent huntingLicense = new src.Models.HuntingBase();
        src.Models.LicenseDecorator dec = new src.Models.Decorators.DeerPermit(huntingLicense);
        dec = new src.Models.Decorators.TurkeyPermit(dec);
        dec = new src.Models.Decorators.MuzzleLoadingPermit(dec);

        src.Models.aLicenseComponent freshLicense = new src.Models.FreshwaterFishBase();
        src.Models.LicenseDecorator fresh = new src.Models.Decorators.SnookPermit(freshLicense);

        Console.WriteLine("Total annual licesnse fee for {0} is {1}", dec.GetName().ToString(), dec.GetPrice().ToString());
        Console.WriteLine("Total annual licesnse fee for {0} is {1}", fresh.GetName().ToString(), fresh.GetPrice().ToString());

        }
    }
}