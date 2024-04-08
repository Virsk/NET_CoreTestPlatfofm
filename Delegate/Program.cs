using Delegate.Models;


Console.WriteLine("Delegates as event enablers \n");
// Создать объект Car.
Car cl = new Car("SlugBug", 100, 0);

bool chack = false;
//подписка
cl.listOfHandlers += OnCarEngineEvent;
cl.func += new Func<int, int, int>(FuncTest);
cl.action += new Action<int, string>(ActionTest);
cl.showMassage += (string arg1, int arg2) => Console.WriteLine($"event {arg1} {arg2}");

while (true)
{
    Console.WriteLine("Растояние поездки");
    string input = Console.ReadLine();
    Console.WriteLine();

    if (int.TryParse(input, out int number))
    {
        cl.Accelerate(number);
    }

    else if (input == "off")
    {
        if (chack)
        {
            cl.listOfHandlers -= OnCarEngineEvent2;
            chack = false;
        }
        cl.listOfHandlers("режим для слабовидящих Выключен");
    }

    else
    {
        Console.WriteLine("Вы перепуталт цифры и буквы (Включен режим для слабовидящих) для выкллчения введите 'off' ");
        if (!chack)
        {
            cl.listOfHandlers += OnCarEngineEvent2;
            chack = true;
        }
    }
}

void OnCarEngineEvent(string msg)
{
    Console.WriteLine("Состояние машины для зрячих");
    Console.Write("=> {0}", msg);
    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!");
    Console.WriteLine();
}

void OnCarEngineEvent2(string msg)
{
    Console.WriteLine("Состояние машины для слабовидящих");
    Console.Write("=> {0}", msg.ToUpper());
    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!");
    Console.WriteLine();
}

void ActionTest(int number, string masage)
{
    Console.WriteLine($"{number}  {masage}");
}

int FuncTest(int numberFirst, int number)
{
    return number - numberFirst;
}

