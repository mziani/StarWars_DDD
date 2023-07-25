using System;

namespace StarWars_DDD.Véhicules_Domain
{
    public class StarshipFactory
    {
        public static Starship Make(string type)
        {
            if (type.Equals("Corvette", StringComparison.OrdinalIgnoreCase))
            {
                return new CorvetteStarship();
            }
            else if (type.Equals("StarDestroyer", StringComparison.OrdinalIgnoreCase))
            {
                return new StarDestroyerStarship();
            }
            else
            {
                throw new ArgumentException("Invalid starship type.");
            }
        }
    }
}
