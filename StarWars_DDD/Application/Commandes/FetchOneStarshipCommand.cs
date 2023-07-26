using StarWars_DDD.Domain;
using System;
using System;
using System.Net.Http;
using System.Text.Json;

namespace StarWars_DDD.Application.Commands
{
    public class FetchOneStarshipCommand : ICommand<StarshipResponse>
    {

        public IResponseHandler<StarshipResponse> SuccessHandler { get; set; }


        public IErrorHandler ErrorHandler { get; set; }


        public int StarshipId { get; set; }

        public StarshipResponse Execute()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {

                    var response = httpClient.GetStringAsync($"https://swapi.dev/api/starships/{StarshipId}").Result;

                    var starshipResponse = JsonSerializer.Deserialize<StarshipResponse>(response);


                    return starshipResponse;
                }
            }
            catch (Exception ex)
            {

                ErrorHandler?.Handle(ex);
                return null;
            }
        }
    }
}