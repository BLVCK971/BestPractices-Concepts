using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Automobile;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Scooter;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Factories.Vehicles;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Factories.Vehicles.Essence;

public class FabriqueVehiculeEssence : FabriqueVehicule
{
    public Automobile creeAutomobile(string modele, string couleur, int puissance, double espace)
    {
        return new AutomobileEssence(modele, couleur, puissance, espace);
    }

    public Scooter creeScooter(string modele, string couleur, int puissance)
    {
        return new ScooterEssence(modele, couleur, puissance);
    }
}