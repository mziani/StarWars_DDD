using StarWars_DDD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars_DDD.Véhicules_Domain
{

        public class Starship : IVehicule, IVehiculeSpecifique
    {

        public string? Name { get; set; }
        public int Speed { get; set; }

        public bool DemarrerAppellee;
        public bool EmbarquerAppellee;
        public bool ArreterAppellee;
        public bool TirerAppellee;
        public bool VolerAppellee;

        public void Demarrer()
        {
            Console.WriteLine($"{Name} démarré.");
        }

        public void Arreter()
        {
            Console.WriteLine($"{Name} arrêté.");
        }

        public void Embarquer()
        {
            Console.WriteLine($"Embarquement dans le {Name}");
        }

        public void Tirer()
        {
            //return "Le Starship ouvre le feu !";
            Console.WriteLine($"{Name} ouvre le feu !");
        }

        public void Voler()
        {
            Console.WriteLine($"{Name} vole dans l'espace.");
            //return "Le Starship vole dans l'espace.";
        }

        public void Tourner()
        {
            //return "Le Starship change de cap";
            Console.WriteLine($"{Name} change de cap");
        }

        public void Decoller()
        {
            //return "Le Starship decolle";
            Console.WriteLine($"{Name} decolle");
        }

        public void Aterrir()
        {
            //return "Le Starship atterrit";
            Console.WriteLine($"{Name} atterrit");
        }
        public string GetVehicleType()
        {
            return "Starship";
        }
    }
}

