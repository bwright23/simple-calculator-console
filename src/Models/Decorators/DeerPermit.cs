using FishingLicense.src.Models;

namespace FishingLicense.src.Models.Decorators
{
    public class DeerPermit: LicenseDecorator
    {
        public DeerPermit (aLicenseComponent license) :base(license)
        {
            this._name = "Deer Permit";
            this._price = 5.00;
        }
    }
}