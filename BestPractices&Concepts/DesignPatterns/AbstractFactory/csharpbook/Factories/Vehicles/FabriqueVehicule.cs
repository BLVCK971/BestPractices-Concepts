using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Automobile;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Scooter;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Factories.Vehicles;

public interface FabriqueVehicule
{
    Automobile creeAutomobile(string modele, string couleur, int puissance, double espace);
    Scooter creeScooter(string modele, string couleur, int puissance);
}
