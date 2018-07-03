using System.Collections.Generic;

namespace FishingLicense.src.Models
{
    public class FishermanBase
    {
        private string _Name =string.Empty;
        private int _StartingAge = 0;
        private int _BreakEvenAge = 0;
        private int _EndingAge = 65;
      
        Dictionary<object ,src.Models.aLicenseComponent>  _selectedLicenses;

        public  FishermanBase()
        {
            _selectedLicenses = new Dictionary<object, src.Models.aLicenseComponent>();
        }
        public Dictionary<object,src.Models.aLicenseComponent> SelectedLicenses
        {
            get {return _selectedLicenses;}
            set {_selectedLicenses = value;}
        }

        public string Name
        {
            get {return _Name;}
            set {_Name=  value;}
        }
        public  int StartingAge
        {
            get {return _StartingAge;}
            set {_StartingAge =  value;}
        }
        public  int BreakEvenAge
        {
            get {return _BreakEvenAge;}
            set {_BreakEvenAge=  value;}
        }
        public  int EndingAge
        {
            get {return _EndingAge;}
            set {_EndingAge=  value;} 
        }
        
    }
}