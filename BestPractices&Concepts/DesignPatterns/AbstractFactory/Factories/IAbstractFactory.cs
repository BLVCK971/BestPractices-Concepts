using BestPractices_Concepts.DesignPatterns.AbstractFactory.Contracts;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.Factories;

internal interface IAbstractFactory
{
    IAbstractProtocol CreateProtocol();
    IAbstractModule CreateModule();
}
