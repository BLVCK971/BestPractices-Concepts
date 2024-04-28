using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Scooter
{
    public abstract class Scooter
    {
        protected string modele;
        protected string couleur;
        protected int puissance;

        public Scooter(string modele, string couleur, int puissance)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.puissance = puissance;
        }

        public abstract void afficherCaracteristiques();
    }
}
