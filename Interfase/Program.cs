using Interfase.Models;

Car car1 = new Car() { CarlD = 99999, CurrentSpeed=100, PetName = "Tesla"};
Car car2 = (Car)car1.Clone();
Car car3 = (Car)car2.Clone();

List<Car> cars =
[
    new Car("Djiguli", 100, 5), 
    new Car("Astin", 100, 12),
    new Car("Ford", 100, 21), 
    new Car("Opel", 100, 16),
    new Car("Tavria", 100, 8), 
    new Car("Kamaz", 100, 4),
    new Car("Volvo", 100, 9), 
    new Car("Mers", 100, 2),
    .. new List<Car> { car1, car2, car3 },

];

cars.Sort();
foreach (var car in cars)
{
    Console.Write(car.PetName + ' ');
    Console.WriteLine(car.CarlD);
}
Console.WriteLine("//////////////");

cars.Sort(Car.SortByPetName);
foreach (var car in cars)
{
    Console.Write(car.PetName + ' ');
    Console.WriteLine(car.CarlD);
}
Console.WriteLine("//////////////");

foreach (var item in car1)
{
    Console.WriteLine(item);
}


