using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Automobile;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Scooter;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Factories.Vehicles;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Factories.Vehicles.Electric;
using BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Factories.Vehicles.Essence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook;

public static class Catalogue
{
    public static int nbAutos = 3;
    public static int nbScooters = 2;

    public static void mainFunction()
    {
        FabriqueVehicule factory;

        Automobile[] autos = new Automobile[nbAutos];
        Scooter[] scooters = new Scooter[nbScooters];

        Console.WriteLine("Voulez-vous utiliser " + "des véhicules électric (1) ou essence (2) :");
        string choix = Console.ReadLine();

        if (choix == "1")
        {
            factory = new FabriqueVehiculeElectrique();
        }
        else
        {
            factory = new FabriqueVehiculeEssence();
        }

        for (int i = 0; i < nbAutos; i++)
        {
            autos[i] = factory.creeAutomobile("standard", "jaune", 6 + i, 3.2);
        }
        for (int i = 0; i < nbScooters; i++)
        {
            scooters[i] = factory.creeScooter("classic", "rouge", 2 + i);
        }
    }
}
