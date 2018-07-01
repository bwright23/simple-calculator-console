namespace FishingLicense.src.Models
{
    public class HuntingBase: aLicenseComponent
    {
        private string _Name = "Hunting License";
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