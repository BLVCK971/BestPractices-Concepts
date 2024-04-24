namespace BestPractices_Concepts.BaseConcepts.OOP.Encapsulation;

public class Airport
{
    public static void Accept(ITransport vehicle)
    {
        vehicle.Run("Nice", "Madrid", 4);
    }
}
