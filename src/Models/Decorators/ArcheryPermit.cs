namespace FishingLicense.src.Models.Decorators
{
    public class ArcheryPermit: LicenseDecorator
    {
        public ArcheryPermit (aLicenseComponent license) :base(license)
        {
            this._name = "Archery Permit";
            this._price = 5.00;
        }
    }
}