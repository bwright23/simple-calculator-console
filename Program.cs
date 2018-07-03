using System;
using FishingLicense;
using FishingLicense.src;
using System.Collections.Generic;

namespace FishingLicense
{
    class Program
    {
        static src.Models.FishermanBase person = src.CalculateFactory.CreateInstance<src.Models.FishermanBase>();
            
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

            src.Models.aLicenseComponent huntingLicense = new src.Models.HuntingBase();
            src.Models.LicenseDecorator dec = new src.Models.Decorators.DeerPermit(huntingLicense);
            dec = new src.Models.Decorators.TurkeyPermit(dec);
            dec = new src.Models.Decorators.MuzzleLoadingPermit(dec);
            dec = new src.Models.Decorators.WMAPermit(dec);
            dec = new src.Models.Decorators.ArcheryPermit(dec);
            dec = new src.Models.Decorators.CrossbowPermit(dec);
            person.SelectedLicenses.Add(dec.GetType(), dec);

            src.Models.aLicenseComponent freshLicense = new src.Models.FreshwaterFishBase();
            person.SelectedLicenses.Add(freshLicense.GetType(), freshLicense);

            src.Models.aLicenseComponent saltLicense = new src.Models.SaltWaterFishBase();
            src.Models.LicenseDecorator salt = new src.Models.Decorators.SnookPermit(saltLicense);
            salt = new src.Models.Decorators.SpinyLobsterPermit(saltLicense);
            person.SelectedLicenses.Add(salt.GetType(), salt);
           
        }

        static void DetermineSavings()
        {
            double price = 0.00;
            double totalCost = 0.00;
            double ageDiff = 0;
            double totalSavings = 0;

            string t = string.Empty;
            double lifetimePrice = src.CalculateFactory.CreateInstance<src.Models.LifetimeLicenseBase>().GetPrice();
            src.Models.IOperator add = src.CalculateFactory.CreateInstance<src.Logic.OperatorAdd>();
            src.Models.IOperator minus = src.CalculateFactory.CreateInstance<src.Logic.OperatorSub>();
            src.Models.IOperator multiply = src.CalculateFactory.CreateInstance<src.Logic.OperatorMultiply>();


            Console.WriteLine("Hello {0} you're age is {1}", person.Name, person.StartingAge);
            Console.WriteLine("");

            foreach (KeyValuePair<object , src.Models.aLicenseComponent> entry in person.SelectedLicenses)
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