using System;
using System.Collections.Generic;

namespace StarWars_DDD.Application.Handlers
{
    public class FetchAllStarshipsCommandHandler : IResponseHandler<List<StarshipResponse>>
    {
        public void Handle(List<StarshipResponse> response)
        {
            foreach (var starship in response)
            {
                Console.WriteLine($"Name: {starship.Name}, Model: {starship.Model}, Manufacturer: {starship.Manufacturer}");
            }
        }
    }
}