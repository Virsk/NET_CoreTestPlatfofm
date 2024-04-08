using Jeneric.Enums;

namespace Jeneric.Interfaces
{
    public interface IEngine
    {
        EngineType Type { get; }
        public void LetsGO();
    }
}
