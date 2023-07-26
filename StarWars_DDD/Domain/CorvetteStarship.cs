using StarWars_DDD.Domain;
using System;
using System.Xml.Linq;

namespace StarWars_DDD.Domain
{
    public class CorvetteStarship : Starship
    {
        public int PassagersCount { get; private set; }

        public int CountPassengers()
        {
            Random random = new Random();
            PassagersCount = random.Next(50, 101);

            Console.WriteLine($"Corvette {Name} a {PassagersCount} passagers.");
            return PassagersCount;
        }
    }
}