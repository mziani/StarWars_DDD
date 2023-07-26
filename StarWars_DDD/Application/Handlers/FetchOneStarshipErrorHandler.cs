using System;

namespace StarWars_DDD.Application.Handlers
{
    public class FetchOneStarshipErrorHandler : IErrorHandler
    {
        public void Handle(Exception ex)
        {
            Console.WriteLine($"Erreur lors de la recuperation des starships: {ex.Message}");
        }
    }
}