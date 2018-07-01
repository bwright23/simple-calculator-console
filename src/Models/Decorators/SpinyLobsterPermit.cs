namespace FishingLicense.src.Models.Decorators
{
    public class SpinyLobsterPermit: LicenseDecorator
    {
        public SpinyLobsterPermit (aLicenseComponent license) :base(license)
        {
            this._name = "Spiny Lobster Permit";
            this._price = 5.00;
        }
    }
}