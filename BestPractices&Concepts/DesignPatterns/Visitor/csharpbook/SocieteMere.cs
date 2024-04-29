using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.Visitor.csharpbook;

public class SocieteMere : Societe
{
    protected IList<Societe> filiales = new List<Societe>();

    public SocieteMere(string nom, string email, string adresse) : base(nom, email, adresse) { }

    public override void accepteVisiteur(Visiteur visiteur)
    {
        visiteur.visite(this);
        foreach(Societe filiale in filiales)
        {
            filiale.accepteVisiteur(visiteur);
        }
    }

    public override bool ajouteFilliale(Societe filliale)
    {
        filiales.Add(filliale);
        return true;
    }
}
