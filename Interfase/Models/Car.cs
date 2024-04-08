using System.Collections;

namespace Interfase.Models
{
    public class Car : IComparable, ICloneable, IEnumerable
    {
        public int CarlD { get; set; }
        // Константа для представления максимальной скорости,
        public const int MaxSpeed = 100;
        // Свойства автомобиля.
        public int CurrentSpeed { get; set; } = 0;

        public static IComparer<Car> SortByPetName
        { get { return (IComparer<Car>)new NameSort(); } }

        public string PetName { get; set; } = "";

        //He вышел ли автомобиль из строя?
        private bool carlsDead;
        //В автомобиле имеется радиоприемник,
        private Radio theMusicBox = new Radio();
        // Конструкторы,
        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarlD = id;
        }
        public Car() { }
        public void CrankTunes(bool state)
        {
            // агрегация
            theMusicBox.TurnOn(state);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Car temp)
                return this.CarlD.CompareTo(temp.CarlD);
            else
                throw new ArgumentException("Parameter is not a Car!");
        }

        public object Clone()
        {
            Car newCar = (Car)this.MemberwiseClone();
            newCar.theMusicBox = new Radio();
            return newCar;
        }

        public IEnumerator GetEnumerator()
        {
            yield return CarlD;
            yield return CurrentSpeed;
            yield return PetName;
            yield return carlsDead;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }

    public class NameSort : IComparer<Car>
    {
        public int Compare(Car? first, Car? last)
        {
            if (first != null && last != null)
            {
                return String.Compare(first.PetName, last.PetName);
            }
            else
                throw new ArgumentException("Parameter is not a Car!");
        }
    }
}
