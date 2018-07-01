namespace FishingLicense.src.Models.Decorators
{
    public class WMAPermit: LicenseDecorator
    {
        public WMAPermit (aLicenseComponent license) :base(license)
        {
            this._name = "WMP Permit";
            this._price = 26.00;
        }
    }
}