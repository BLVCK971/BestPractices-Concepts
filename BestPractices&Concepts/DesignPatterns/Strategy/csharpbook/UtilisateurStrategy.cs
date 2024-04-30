namespace BestPractices_Concepts.DesignPatterns.Strategy.csharpbook;

public class UtilisateurStrategy
{
    public static void Main()
    {
        VueCatalogue vueCatalogue1 = new VueCatalogue(new DessinTroisVehiculesLigne());
        vueCatalogue1.dessine();
        VueCatalogue vueCatalogue2 = new VueCatalogue(new DessinVehiculeLigne());
        vueCatalogue2.dessine();
    }
}
