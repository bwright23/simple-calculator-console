namespace FishingLicense.src.Models.Decorators
{
    public class SnookPermit: LicenseDecorator
    {
        public SnookPermit (aLicenseComponent license) :base(license)
        {
            this._name = "Snook Permit";
            this._price = 10.00;
        }
    }
}