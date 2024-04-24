using BestPractices_Concepts.DesignPatterns.Factory.Contracts;

namespace BestPractices_Concepts.DesignPatterns.Factory.Entities;

public class EIP : IProtocol
{
    public string Communicate()
    {
        return "Je parle en EIP";
    }
}
