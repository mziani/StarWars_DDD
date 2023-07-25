using StarWars_DDD.Interfaces;
using StarWars_DDD.Entités;
using System;
using System.Net.NetworkInformation;
/* using System.Collections.Generic;
using StarWars_DDD.Véhicules_Domain;
using System.Net;

namespace StarWars_DDD
{
    class Program
    {
        static void Main(string[] args)
        {

            IVehicule starship = new Starship();
            IVehicule airspeeder = new Airspeeder();

            List<IVehicule> vehicules = new List<IVehicule> { starship, airspeeder };

            Pilote pilote = new Pilote(vehicules);


            pilote.ConduirToutVehicules();

            Console.ReadKey();
        }
    }
}
*/
using System;

namespace StarWars_DDD.Véhicules_Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Starship corvette = StarshipFactory.Make("Corvette");
            corvette.Name = "Millennium Falcon";
            corvette.Demarrer();
            corvette.Embarquer();

            if (corvette is CorvetteStarship corvetteStarship)
            {
                int passengerCount = corvetteStarship.CountPassengers();
                Console.WriteLine($"Corvette {corvette.Name} a {passengerCount} passengers.");
            }

            Starship starDestroyer = StarshipFactory.Make("StarDestroyer");
            starDestroyer.Name = "Imperial-class Star Destroyer";
            starDestroyer.Demarrer();
            starDestroyer.Embarquer();

            if (starDestroyer is StarDestroyerStarship starDestroyerStarship)
            {
                starDestroyerStarship.Attack(corvette);
            }

            Console.ReadKey();
        }
    }
}
