using System;
using FishingLicenseCore;
using Calculator;
using System.Collections.Generic;

namespace FishingLicense
{
    class Program
    {
        
        static FishingLicenseCore.src.Models.FishermanBase person = CalculateFactory.CreateInstance<FishingLicenseCore.src.Models.FishermanBase>();
            
        static void Main(string[] args)
        {
           GetArgs(); 
           BuildLicense();
           DetermineSavings();
        }

        static void GetArgs()
        {
            Console.WriteLine("Enter your starting age:");
            var age = Console.ReadLine();
            
            person.Name = "Bwright23";
            person.StartingAge = int.Parse(age);
            
            Console.Clear();
        }

        static void BuildLicense()
        {

            FishingLicenseCore.src.Models.aLicenseComponent huntingLicense = new FishingLicenseCore.src.Models.HuntingBase();
            FishingLicenseCore.src.Models.LicenseDecorator dec = new FishingLicenseCore.src.Models.Decorators.DeerPermit(huntingLicense);
            dec = new FishingLicenseCore.src.Models.Decorators.TurkeyPermit(dec);
            dec = new FishingLicenseCore.src.Models.Decorators.MuzzleLoadingPermit(dec);
            dec = new FishingLicenseCore.src.Models.Decorators.WMAPermit(dec);
            dec = new FishingLicenseCore.src.Models.Decorators.ArcheryPermit(dec);
            dec = new FishingLicenseCore.src.Models.Decorators.CrossbowPermit(dec);
            person.SelectedLicenses.Add(dec.GetType(), dec);

            FishingLicenseCore.src.Models.aLicenseComponent freshLicense = new FishingLicenseCore.src.Models.FreshwaterFishBase();
            person.SelectedLicenses.Add(freshLicense.GetType(), freshLicense);

            FishingLicenseCore.src.Models.aLicenseComponent saltLicense = new FishingLicenseCore.src.Models.SaltWaterFishBase();
            FishingLicenseCore.src.Models.LicenseDecorator salt = new FishingLicenseCore.src.Models.Decorators.SnookPermit(saltLicense);
            salt = new FishingLicenseCore.src.Models.Decorators.SpinyLobsterPermit(salt);
            person.SelectedLicenses.Add(salt.GetType(), salt);
           
        }

        static void DetermineSavings()
        {
            double price = 0.00;
            double totalCost = 0.00;
            double ageDiff = 0;
            double totalSavings = 0;

            string t = string.Empty;
            double lifetimePrice = CalculateFactory.CreateInstance<FishingLicenseCore.src.Models.LifetimeLicenseBase>().GetPrice();
            Calculator.Logic.IOperator add = CalculateFactory.CreateInstance<Calculator.Logic.OperatorAdd>();
            Calculator.Logic.IOperator minus = CalculateFactory.CreateInstance<Calculator.Logic.OperatorSub>();
            Calculator.Logic.IOperator multiply = CalculateFactory.CreateInstance<Calculator.Logic.OperatorMultiply>();


            Console.WriteLine("Hello {0} you're age is {1}", person.Name, person.StartingAge);
            Console.WriteLine("");

            foreach (KeyValuePair<object , FishingLicenseCore.src.Models.aLicenseComponent> entry in person.SelectedLicenses)
            {
                price +=  entry.Value.GetPrice();
                t = entry.Key.ToString();
                
                Console.WriteLine("{0}: Cost: ${1}", entry.Value.GetName() ,entry.Value.GetPrice());
            }
            
            totalCost = multiply.Calculate(price, minus.Calculate(person.EndingAge, person.StartingAge));
            ageDiff = minus.Calculate(person.EndingAge, person.StartingAge);
            totalSavings = minus.Calculate(totalCost, lifetimePrice);
            
            Console.WriteLine(new string('_',50));
            Console.WriteLine("");
            Console.WriteLine("Total Annual Cost: ${0} ", price);
            Console.WriteLine("Total Annual Cost over {0} years: ${1} ", ageDiff, totalCost);
            Console.WriteLine("Total Lifetime license: ${0} ", lifetimePrice);
            Console.WriteLine("Total Savings: ${0} ", totalSavings);
        }
    }
}