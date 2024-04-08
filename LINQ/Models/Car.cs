namespace Extensions_LINQ.Models
{
    public class Car
    {
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }

        public override int GetHashCode()
        {
            return MaxSpeed.GetHashCode() ^ PetName.GetHashCode() ^ Color.GetHashCode() ^ Make.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Car))
                return false;

            var otherCar = (Car)obj;
            return Make == otherCar.Make && Color == otherCar.Color && PetName == otherCar.PetName && PetName == otherCar.PetName;
        }
    }
}
