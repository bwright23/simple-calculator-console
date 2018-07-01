namespace FishingLicense.src.Models.Decorators
{
    public class TarponPermit: LicenseDecorator
    {
        public TarponPermit (aLicenseComponent license) :base(license)
        {
            this._name = "Tarpon Permit";
            this._price = 51.50;
        }
    }
}