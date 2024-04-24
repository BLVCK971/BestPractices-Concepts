using BestPractices_Concepts.DesignPatterns.Factory.Creators;

namespace BestPractices_Concepts.DesignPatterns.Factory;

public class Client
{
    public static void ClientCode(ProtocolCreator creator)
    {
        Console.WriteLine(creator.TryCommunicate());
    }
}
