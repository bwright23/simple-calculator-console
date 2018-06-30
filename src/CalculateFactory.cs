namespace FishingLicense.src
{
   static public class CalculateFactory
    {
        public static T CreateInstance<T>() where T: new ()
        {
            return new T();
        }
    }
}