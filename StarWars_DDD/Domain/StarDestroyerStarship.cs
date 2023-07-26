using System;
using System.Xml.Linq;

namespace StarWars_DDD.Domain
{
    public class StarDestroyerStarship : Starship
    {
        public void Attack(Starship target)
        {
            Console.WriteLine($"StarDestroyer est entrain d'attaquer {target.Name}!");
        }
    }
}