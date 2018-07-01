namespace FishingLicense.src.Models
{
    public class FishermanBase
    {
        private string _Name =string.Empty;
        private int _StartingAge = 0;
        private int _BreakEvenAge = 0;
        private int _EndingAge = 0;
      

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