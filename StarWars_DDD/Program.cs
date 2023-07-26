using StarWars_DDD.Domain.Interfaces;
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
/*
using System;
using StarWars_DDD.Domain;

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
*/
using System;

using System;
using System.Collections.Generic;
using StarWars_DDD.Application;
using StarWars_DDD.Application.Commands;
using StarWars_DDD.Application.Handlers;

namespace StarWars_DDD
{
    class Program
    {
        static void Main(string[] args)
        {

            var commandBus = new StarshipCommandBus();


            var fetchAllStarshipsCommand = new FetchAllStarshipsCommand();
            var fetchAllStarshipsCommandHandler = new FetchAllStarshipsCommandHandler();
            fetchAllStarshipsCommand.SuccessHandler = fetchAllStarshipsCommandHandler;


            var fetchOneStarshipCommand = new FetchOneStarshipCommand { StarshipId = 2 }; 
            var fetchOneStarshipCommandHandler = new FetchOneStarshipCommandHandler();
            fetchOneStarshipCommand.SuccessHandler = fetchOneStarshipCommandHandler;

            Console.WriteLine("Récupération de tout les starships:");
            commandBus.Execute(fetchAllStarshipsCommand);

            Console.WriteLine("\nRécupératione d'une starship:");
            commandBus.Execute(fetchOneStarshipCommand);

            Console.ReadKey();
        }
    }
}