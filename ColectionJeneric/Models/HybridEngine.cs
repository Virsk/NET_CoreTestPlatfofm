using Jeneric.Enums;
using Jeneric.Interfaces;

namespace Jeneric.Models
{
    public class HybridEngine : IEngine
    {
        public EngineType Type { get; }


        public HybridEngine() {
            Type = EngineType.hybridEngine;
        }

        public void LetsGO()
        {
            Console.WriteLine("Без нагрузки еду тихо. Кое как выжила");
        }
    }
}
