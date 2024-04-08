using Extensions_LINQ.Extens;using Extensions_LINQ.Models;
List<int> mylnts = new List<int>() { 20, 1, 4, 8, 9, 44 };
mylnts.PrintDataAndBeep();
Console.WriteLine();

List<int> evenNumbers = mylnts.FindAll(i => (i % 2) == 0);
evenNumbers.ForEach(i => Console.WriteLine(i));
Console.WriteLine();

string[] currentVideoGames = ["Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"];var subset = from g in currentVideoGames
             where g.Contains(' ')
             orderby g
             select g;var subset2 = currentVideoGames.
              Where(g => g.Contains(' ')).
              OrderBy(g => g).
              Select(g => g);

var subset3 = mylnts.
              Where(i => i < 10).
              Select(i => i);

ReflectOverQueryResults(subset);
Console.WriteLine();
ReflectOverQueryResults(subset2);
Console.WriteLine();
ReflectOverQueryResults(subset3);
Console.WriteLine();

foreach (string s in subset)
{
    Console.WriteLine(s);
}
static void ReflectOverQueryResults(object resultSet)
{
    // Вывести тип результирующего набора.
    Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
    // Вывести местоположение результирующего набора.
    Console.WriteLine("resultSet location: {0}",
    resultSet.GetType().Assembly.GetName().Name);
}

List<Car> cars = new List<Car>() {
    new Car{ PetName="Henry", Color = "Silver", MaxSpeed = 100, Make = "BMW"},
    new Car{ PetName="Daisy", Color ="Tan", MaxSpeed = 90, Make = "BMW"},
    new Car{ PetName = "Mary", Color = "Black", MaxSpeed = 55, Make = "VW"},
    new Car{ PetName ="Clunker", Color = "Rust", MaxSpeed = 5, Make = "Yugo"},
    new Car{ PetName="Melvin", Color = "White", MaxSpeed = 43, Make = "Ford"}
};

List<Car> myCars = new List<Car>() {
    new Car{ PetName="Henry", Color = "Silver", MaxSpeed = 100, Make = "BMW"},
    new Car{ PetName ="Clunker", Color = "Rust", MaxSpeed = 5, Make = "Yugo"},
    new Car{ PetName="Melvin", Color = "White", MaxSpeed = 43, Make = "Ford"}
};

var fastCars = cars.Where(c => c.MaxSpeed > 60).
                    Select(c => new { c.Make, c.MaxSpeed }).
                    OrderByDescending(c => c.MaxSpeed).
                    ToList();
fastCars.ForEach(c => Console.WriteLine($"{c.Make} {c.MaxSpeed}"));
Console.WriteLine();
var carDiff = (cars.Select(c => c)).
                    Except(myCars.Select(c2 => c2)).
                    ToList();

var carlntersect = (cars.Select(c => c).Intersect(myCars.Select(c2 => c2)).ToList());

carDiff.ForEach(c => Console.WriteLine(c.Make));
Console.WriteLine();
carlntersect.ForEach(c => Console.WriteLine(c.Make));