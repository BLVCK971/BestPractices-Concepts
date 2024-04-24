namespace BestPractices_Concepts.BaseConcepts.OOP.Encapsulation;

public class Airplane : ITransport
{
    public void Run(string origin, string destination, int passengers)
    {
        Console.WriteLine("Salut je suis un avion et je vais de " + origin + " à " + destination + " avec " + passengers + " passagers");
    }
}
