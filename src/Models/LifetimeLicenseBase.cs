namespace FishingLicense.src.Models
{
    public class LifetimeLicenseBase: aLicenseComponent
    {
        private src.Models.LicenseDecorator _huntingDecorate = null;
        private src.Models.LicenseDecorator _freshDecorate = null;
        private src.Models.LicenseDecorator _saltDecorate = null;
        private string _Name = "Lifetime License";
        private double _price = 1001.50;
      
        public LifetimeLicenseBase()
        {
            src.Models.aLicenseComponent huntingLicense = new src.Models.HuntingBase();
            _huntingDecorate = new src.Models.Decorators.DeerPermit(huntingLicense);
            _huntingDecorate = new src.Models.Decorators.TurkeyPermit(_huntingDecorate);
            _huntingDecorate = new src.Models.Decorators.MuzzleLoadingPermit(_huntingDecorate);
            _huntingDecorate = new src.Models.Decorators.WMAPermit(_huntingDecorate);
            _huntingDecorate = new src.Models.Decorators.ArcheryPermit(_huntingDecorate);
            _huntingDecorate = new src.Models.Decorators.CrossbowPermit(_huntingDecorate);

            src.Models.aLicenseComponent freshLicense = new src.Models.FreshwaterFishBase();
            _freshDecorate = new src.Models.Decorators.SnookPermit(freshLicense);
            
            src.Models.aLicenseComponent saltLicense = new src.Models.SaltWaterFishBase();
            _saltDecorate = new src.Models.Decorators.SnookPermit(saltLicense);
            _saltDecorate = new src.Models.Decorators.SpinyLobsterPermit(_saltDecorate);
        }
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