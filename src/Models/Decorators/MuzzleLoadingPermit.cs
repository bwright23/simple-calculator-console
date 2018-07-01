namespace FishingLicense.src.Models.Decorators
{
    public class MuzzleLoadingPermit: LicenseDecorator
    {
        public MuzzleLoadingPermit (aLicenseComponent license) :base(license)
        {
            this._name = "MuzzleLoading Permit";
            this._price = 5.00;
        }
    }
}