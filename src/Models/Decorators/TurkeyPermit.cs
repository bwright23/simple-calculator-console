namespace FishingLicense.src.Models.Decorators
{
    public class TurkeyPermit: LicenseDecorator
    {
        public TurkeyPermit (aLicenseComponent license) :base(license)
        {
            this._name = "Turkey Permit";
            this._price = 5.00;
        }
    }
}