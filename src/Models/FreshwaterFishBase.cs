namespace FishingLicense.src.Models
{
      public class FreshwaterFishBase: aLicenseComponent
    {
        private string _Name = "Freshwater License";
        private double _price = 17.00;
      
        public override string GetName()
        {
            return _Name;
        }

        public override double GetPrice()
        {
            return _price;
        }
        
    }
}