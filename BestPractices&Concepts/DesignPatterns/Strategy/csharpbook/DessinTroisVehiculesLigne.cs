namespace BestPractices_Concepts.DesignPatterns.Strategy.csharpbook;

public class DessinTroisVehiculesLigne : DessinCatalogue
{
    public void dessine(IList<VueVehicule> contenu)
    {
        int compteur = 0;
        Console.WriteLine("Dessine les véhicules avec 3 véhicules par ligne :");
        foreach (VueVehicule vue in contenu)
        {
            vue.dessine();
            compteur++;
            if (compteur == 3)
            {
                compteur = 0;
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
        if (compteur != 0)
        {
            Console.WriteLine();
        }
    }
}
