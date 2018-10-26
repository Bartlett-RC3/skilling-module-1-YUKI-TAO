using System; 

namespace SH2DogClass
{
    public class Dog
    {
        string Name;
        string Gender;
        int Age;
        double Weight;

      public Dog(string _Name, string _Gender, int _Age, double _Weight)
        {
            Name = _Name;            
            Gender = _Gender;
            Age = _Age;
            Weight = _Weight;
          }



        public string GetName()
        {
        return Name;
        }

        public string GetGender()
        {
            return Gender;

        }

        public int GetAge()
       {
        return Age ;
        
         }
        public double GetWeight()
        {
            return Weight;

        }
    }
}