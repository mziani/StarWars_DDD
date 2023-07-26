using StarWars_DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars_DDD.Véhicules_Domain
{
    public class Airspeeder : IVehicule
    {
        public bool DemarrerAppellee;
        public bool EmbarquerAppellee;
        public bool ArreterAppellee;
        public bool TirerAppellee;

        // Implémentation des méthodes de l'interface IVehicle
        public void Demarrer()
        {
            Console.WriteLine("Airspeeder démarré.");
        }

        public void Arreter()
        {
            Console.WriteLine("Airspeeder arrêté.");

        }

        public void Embarquer()
        {
            Console.WriteLine("Embarquement dans l'airspeeder.");
        }

         public void Tourner()
        {
            Console.WriteLine("Airspeeder change de cap !");
        }
        public string GetVehicleType()
        {
            return "AirSpeeder";
        }

    }
}
