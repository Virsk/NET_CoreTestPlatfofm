using System.Collections.Generic;

EqualityTest();

static void EqualityTest()
{
    var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
    var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
    // Считаются ли они эквивалентными, когда используется Equals()?
    if (firstCar.Equals(secondCar))
        Console.WriteLine("Same anonymous object!"); 
    else
        Console.WriteLine("Not the same anonymous object!"); 
    if (firstCar == secondCar)
        Console.WriteLine("Same anonymous object!");
    else
        Console.WriteLine("Not the same anonymous object!");
    // Имеют ли эти объекты в основе один и тот же тип?
    if (firstCar.GetType().Name == secondCar.GetType().Name)
        Console.WriteLine("We are both the same type!"); 
    else
        Console.WriteLine("We are different types!"); 
    Console.WriteLine();
    ReflectOverAnonymousType(firstCar);
    ReflectOverAnonymousType(secondCar);
}

static void ReflectOverAnonymousType(object obj)
{
    Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
    Console.WriteLine("Base class of {0} is {1}",
    obj.GetType().Name,
    obj.GetType().BaseType);
    Console.WriteLine("obj .ToStringO == {0}", obj.ToString());
    Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
    Console.WriteLine();
}
