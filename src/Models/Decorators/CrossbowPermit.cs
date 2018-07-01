namespace FishingLicense.src.Models.Decorators
{
    public class CrossbowPermit: LicenseDecorator
    {
        public CrossbowPermit (aLicenseComponent license) :base(license)
        {
            this._name = "Crossbow Permit";
            this._price = 5.00;
        }
    }
}