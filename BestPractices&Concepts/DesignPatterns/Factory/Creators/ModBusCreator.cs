using BestPractices_Concepts.DesignPatterns.Factory.Contracts;
using BestPractices_Concepts.DesignPatterns.Factory.Entities;

namespace BestPractices_Concepts.DesignPatterns.Factory.Creators;

public class ModBusCreator : ProtocolCreator
{
    public override IProtocol FactoryMethod()
    {
        return new ModBus();
    }
}
