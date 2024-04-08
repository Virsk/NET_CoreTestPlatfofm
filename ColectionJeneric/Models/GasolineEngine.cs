using Jeneric.Enums;
using Jeneric.Interfaces;

namespace Jeneric.Models
{
    public class GasolineEngine : IEngine
    {
        public EngineType Type { get; } 


        public GasolineEngine() {
            Type=EngineType.gasolineEngine;
        }

        public void LetsGO()
        {
            Console.WriteLine("Экология это не про меня. Разлетелась в дребезги");
        }
    }
}
