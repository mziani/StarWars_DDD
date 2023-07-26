using System;

namespace StarWars_DDD.Application.Handlers
{
    public class FetchOneStarshipCommandHandler : IResponseHandler<StarshipResponse>
    {
        public void Handle(StarshipResponse response)
        {
            Console.WriteLine($"Name: {response.Name}, Model: {response.Model}, Manufacturer: {response.Manufacturer}");
        }
    }
}