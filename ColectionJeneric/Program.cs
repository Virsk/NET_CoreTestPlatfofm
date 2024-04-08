using Jeneric.Interfaces;
using Jeneric.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

ObservableCollection<Car<ElectricEngine>> carsAvents = new ObservableCollection<Car<ElectricEngine>>();
ReadOnlyObservableCollection<Car<ElectricEngine>> cars = new ReadOnlyObservableCollection<Car<ElectricEngine>>(carsAvents);

HashSet<Car<GasolineEngine>> carHashSet = new HashSet<Car<GasolineEngine>>();
SortedSet<Car<GasolineEngine>> carSortset = new SortedSet<Car<GasolineEngine>>();

Stack<Car<HybridEngine>> carStack = new Stack<Car<HybridEngine>>();
Queue<Car<HybridEngine>> carQueue = new Queue<Car<HybridEngine>>();

List<Car<IEngine>> CarCrashTest = new List<Car<IEngine>>();

StartObservableCollection();
StartHashSet();
StartSortset();
StartStack();
StartQueue();
CrashTest();

void CrashTest()
{
    Console.WriteLine("////CrashTest////");

    CarCrashTest.Add(new Car<IEngine>(new ElectricEngine(), "Mazda", "AE4655EE", 2));
    CarCrashTest.Add(new Car<IEngine>(new GasolineEngine(), "Mazda", "AE4655EE", 2));
    CarCrashTest.Add(new Car<IEngine>(new HybridEngine(), "Mazda", "AE4655EE", 2));

    foreach (var car in CarCrashTest)
    {
        Console.WriteLine(car.Name);
        car.GetEngineType();
        car.StratDrive();
        Console.WriteLine();
    }
}

void StartObservableCollection()
{
    Console.WriteLine("////ObservableCollection////");

    carsAvents.Add(new Car<ElectricEngine>(new ElectricEngine(), "Tesla", "AE4654EE", 1));

    carsAvents.Add(new Car<ElectricEngine>(new ElectricEngine(), "Mazda", "AE4655EE", 2));

    carsAvents.Add(new Car<ElectricEngine>(new ElectricEngine(), "Ford", "AE4656EE", 3));

    carsAvents.CollectionChanged += carsAvents_CollectionChanged;

    foreach (Car<ElectricEngine> car in cars)
    {
        Console.WriteLine($"{car.Name}, {car.Numder}");
    }

    carsAvents.Add(new Car<ElectricEngine>(new ElectricEngine(), "Lexsus", "AE4657EE", 4));
    Console.WriteLine();
}
void carsAvents_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("event work");
}
void StartHashSet()
{
    Console.WriteLine("////HashSet////");
    Car<GasolineEngine> testCAr = new Car<GasolineEngine>(new GasolineEngine(), "Mazda", "AE4655EE", 2);

    carHashSet.Add(testCAr);
    carHashSet.Add(testCAr);

    carHashSet.Add(new Car<GasolineEngine>(new GasolineEngine(), "jiguli", "AE4654EE", 1));
    carHashSet.Add(new Car<GasolineEngine>(new GasolineEngine(), "jiguli", "AE4654EE", 1));

    carHashSet.Add(new Car<GasolineEngine>(new GasolineEngine(), "Ford", "AE4656EE", 3));
    //carHashSet.RemoveWhere(x => x.Id == 2);
    foreach (var item in carHashSet)
    {
        Console.WriteLine(item.Id);
    }
    Console.WriteLine();
}
void StartSortset()
{
    Console.WriteLine("////Sortset////");
    Car<GasolineEngine> testCAr = new Car<GasolineEngine>(new GasolineEngine(), "Mazda", "AE4655EE", 2);

    carSortset.Add(testCAr);
    carSortset.Add(testCAr);

    carSortset.Add(new Car<GasolineEngine>(new GasolineEngine(), "jiguli", "AE4654EE", 1));
    carSortset.Add(new Car<GasolineEngine>(new GasolineEngine(), "jiguli3", "AE4654EE", 1));
    carSortset.Add(new Car<GasolineEngine>(new GasolineEngine(), "jiguli2", "AE4654EE", 1));


    carSortset.Add(new Car<GasolineEngine>(new GasolineEngine(), "Ford", "AE4656EE", 3));
    //carHashSet.RemoveWhere(x => x.Id == 2);
    foreach (var item in carSortset)
    {
        Console.WriteLine(item.Id);
    }
    Console.WriteLine();
}
void StartStack()
{
    Console.WriteLine("////StartStack////");
    Car<HybridEngine> testCAr = new Car<HybridEngine>(new HybridEngine(), "Mazda", "AE4655EE", 2);

    carStack.Push(testCAr);
    carStack.Push(testCAr);

    carStack.Push(new Car<HybridEngine>(new HybridEngine(), "jiguli", "AE4654EE", 1));
    carStack.Push(new Car<HybridEngine>(new HybridEngine(), "jiguli", "AE4654EE", 1));
    carStack.Push(new Car<HybridEngine>(new HybridEngine(), "jiguli2", "AE4654EE", 1));

    carStack.Push(new Car<HybridEngine>(new HybridEngine(), "Ford", "AE4656EE", 3));
    Console.WriteLine("Before");
    foreach (var item in carStack)
    {
        Console.WriteLine(item.Id);
    }

    Car<HybridEngine> FirstCar = carStack.Pop();

    Console.WriteLine("After");

    foreach (var item in carStack)
    {
        Console.WriteLine(item.Id);
    }

    Console.WriteLine("RemuveFirstCar");
    Console.WriteLine(FirstCar.Id);
    Console.WriteLine();
}
void StartQueue()
{
    Console.WriteLine("////StartStack////");
    Car<HybridEngine> testCAr = new Car<HybridEngine>(new HybridEngine(), "Mazda", "AE4655EE", 2);

    carQueue.Enqueue(testCAr);
    carQueue.Enqueue(testCAr);

    carQueue.Enqueue(new Car<HybridEngine>(new HybridEngine(), "jiguli", "AE4654EE", 1));
    carQueue.Enqueue(new Car<HybridEngine>(new HybridEngine(), "jiguli", "AE4654EE", 1));
    carQueue.Enqueue(new Car<HybridEngine>(new HybridEngine(), "jiguli2", "AE4654EE", 1));

    carQueue.Enqueue(new Car<HybridEngine>(new HybridEngine(), "Ford", "AE4656EE", 3));
    Console.WriteLine("Before");
    foreach (var item in carStack)
    {
        Console.WriteLine(item.Id);
    }

    Car<HybridEngine> LastCar = carQueue.Dequeue();

    Console.WriteLine("After");

    foreach (var item in carStack)
    {
        Console.WriteLine(item.Id);
    }

    Console.WriteLine("RemuveLastCar");
    Console.WriteLine(LastCar.Id);
    Console.WriteLine();
}

