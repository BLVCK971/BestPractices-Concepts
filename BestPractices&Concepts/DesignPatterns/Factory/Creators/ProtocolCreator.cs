using BestPractices_Concepts.DesignPatterns.Factory.Contracts;

namespace BestPractices_Concepts.DesignPatterns.Factory.Creators;

public abstract class ProtocolCreator
{
    public abstract IProtocol FactoryMethod();

    public string TryCommunicate()
    {
        IProtocol product = FactoryMethod();
        string result = "Voici la communication :  " + product.Communicate();

        return result;
    }
}
