using StarWars_DDD.Application;
using System;

namespace StarWars_DDD.Véhicules_Domain
{
    public class FetchAllStarshipsErrorHandler : IErrorHandler
    {
        public void Handle(Exception ex)
        {
            Console.WriteLine($"Erreur lors de la recuperation des starships: {ex.Message}");
        }
    }
}