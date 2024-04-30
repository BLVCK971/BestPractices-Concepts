namespace BestPractices_Concepts.DesignPatterns.Strategy.csharpbook;

public class VueCatalogue 
{
    protected IList<VueVehicule> contenu = new List<VueVehicule>();
    protected DessinCatalogue dessin;

    public VueCatalogue(DessinCatalogue dessin)
    {
        contenu.Add(new VueVehicule("véhicule bon marché"));
        contenu.Add(new VueVehicule("véhicule spacieux"));
        contenu.Add(new VueVehicule("véhicule rapide"));
        contenu.Add(new VueVehicule("véhicule confortable"));
        contenu.Add(new VueVehicule("véhicule sportif"));
        this.dessin = dessin;
    }

    public void dessine()
    {
        dessin.dessine(contenu);
    }
}
