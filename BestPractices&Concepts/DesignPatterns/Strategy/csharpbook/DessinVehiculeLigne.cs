namespace BestPractices_Concepts.DesignPatterns.Strategy.csharpbook;

public class DessinVehiculeLigne: DessinCatalogue
{
    public void dessine(IList<VueVehicule> contenu)
    {
        Console.WriteLine("Dessine les véhicules avec un véhicule par ligne");
        foreach (VueVehicule vue in contenu)
        {
            vue.dessine();
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}
