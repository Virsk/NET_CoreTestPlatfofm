using Jeneric.Enums;
using Jeneric.Interfaces;

namespace Jeneric.Models
{
    public class ElectricEngine : IEngine
    {
        public EngineType Type { get; }


        public ElectricEngine() {
            Type = EngineType.electricEngine;
        }

        public void LetsGO()
        {
            Console.WriteLine("Еду тихо, быстро, долго. Не разбилась");
        }
    }
}
