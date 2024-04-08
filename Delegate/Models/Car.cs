using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    public class Car

    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool carlsDead;

        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;

        }
        public event Action<string, int> showMassage;

        public delegate void CarEngineHandler<T>(T msgForCaller);

        public CarEngineHandler<string> listOfHandlers;

        public Action<int, string> action;

        public Func<int, int, int> func;

        //public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers += methodToCall;
        //}

        //public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers -= methodToCall;
        //}


        public void Accelerate(int delta)
        {
            CurrentSpeed += delta;
            if ((CurrentSpeed > 1000) && listOfHandlers != null)
            {
                listOfHandlers("Sorry, this car is dead...");
               
                listOfHandlers.Invoke("Sorry, this car is dead...");

                action(delta, "Последняя поездка тебя добила");
                MaxSpeed = func(CurrentSpeed, 1000);

            }
                

            else if((CurrentSpeed < 1000) && listOfHandlers != null)
            {
                listOfHandlers("Move on!!! It’s okay");
                action(delta, "В этот раз ты проехал");
                MaxSpeed = func(CurrentSpeed, 1000);
            }

            showMassage?.Invoke(PetName, MaxSpeed);
        }
    }
}