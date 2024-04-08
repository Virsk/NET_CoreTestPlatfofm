
using Jeneric.Enums;
using Jeneric.Interfaces;

namespace Jeneric.Models
{
    public class Car<T>: IComparable<Car<T>> where T: IEngine
    {
        public int Id { get; set; }
        public T? Engine { get; set; } 
        public string? Numder { get; set; }
        public string? Name { get; set; }

        public Car(T engine, string name, string number, int id )
        {
            Engine = engine;
            Numder = number;
            Name = name;
            Id = id;
        }

        public Car() {}

        public int CompareTo(Car<T>? other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            int idComparison = this.Id.CompareTo(other.Id);
            if (idComparison != 0)
                return idComparison;

            // Проверяем Name на null перед сравнением
            if (this.Name == null && other.Name == null)
                return 0;
            if (this.Name == null)
                return -1;
            if (other.Name == null)
                return 1;

            return this.Name.CompareTo(other.Name);
        }

        public void GetEngineType()
        {
            Console.WriteLine(Engine.Type);
        }

        public void StratDrive()
        {
            Engine.LetsGO();
        }

        //переопределенные методы для для HashSet

        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode() ^ Name.GetHashCode() ^ Numder.GetHashCode();
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null || !(obj is Car))
        //        return false;

        //    var otherCar = (Car)obj;
        //    return Id == otherCar.Id && Name == otherCar.Name && Numder == otherCar.Numder;
        //}

    }
}
