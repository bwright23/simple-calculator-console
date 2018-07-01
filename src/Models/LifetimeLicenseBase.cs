namespace FishingLicense.src.Models
{
    public class LifetimeLicenseBase: aLicenseComponent
    {
        private string _Name = "Lifetime License";
        private double _price = 1001.50;
      
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