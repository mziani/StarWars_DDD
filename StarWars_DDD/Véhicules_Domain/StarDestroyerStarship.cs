using StarWars_DDD.Véhicules_Domain;
using System;
using System.Xml.Linq;

namespace StarWars_DDD
{
    public class StarDestroyerStarship : Starship
    {
        public void Attack(Starship target)
        {
            Console.WriteLine($"StarDestroyer est entrain d'attaquer {target.Name}!");
        }
    }
}