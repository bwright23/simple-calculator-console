namespace FishingLicense.src.Models
{
    public abstract class LicenseDecorator :aLicenseComponent
    {
        aLicenseComponent _license =null;   
        protected string _name = "Undefined Decorator";
         protected double _price = 0.0;

        
        protected LicenseDecorator(aLicenseComponent license)
        {
            _license = license;
        }

         public override string GetName()
        {
            return string.Format("{0},{1}", _license.GetName(), _name);
        }

         public override double GetPrice()
        {
            return _price + _license.GetPrice();
        }
    }
}