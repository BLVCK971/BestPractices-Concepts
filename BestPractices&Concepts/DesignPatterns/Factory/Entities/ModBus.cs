using BestPractices_Concepts.DesignPatterns.Factory.Contracts;

namespace BestPractices_Concepts.DesignPatterns.Factory.Entities;

internal class ModBus : IProtocol
{
    public string Communicate()
    {
        return "Je parle en ModBus";
    }
}
