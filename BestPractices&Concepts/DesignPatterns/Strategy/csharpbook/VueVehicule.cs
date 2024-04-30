namespace BestPractices_Concepts.DesignPatterns.Strategy.csharpbook;

public class VueVehicule
{
    protected string description;
    public VueVehicule(string description)
    {
        this.description = description;
    }

    public void dessine()
    {
        Console.WriteLine(description);
    }
}
