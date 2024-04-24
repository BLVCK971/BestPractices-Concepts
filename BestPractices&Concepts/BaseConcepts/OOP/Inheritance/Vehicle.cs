namespace BestPractices_Concepts.BaseConcepts.OOP.Inheritance;

public class Vehicle
{
    private readonly int _id;

    public Vehicle(int id)
    {
        _id = id;
    }

    public string modele { get; set; }

    public void test()
    {
        Console.WriteLine("Nous sommes dans Vehicle");
    }
}
