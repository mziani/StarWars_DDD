using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace StarWars_DDD.Application.Commands
{
    public class FetchAllStarshipsCommand : ICommand<List<StarshipResponse>>
    {
        public IResponseHandler<List<StarshipResponse>> SuccessHandler { get; set; }

        public IErrorHandler ErrorHandler { get; set; }

        public List<StarshipResponse> Execute()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = httpClient.GetStringAsync("https://swapi.dev/api/starships").Result;

                    var result = JsonSerializer.Deserialize<StarshipResult>(response);


                    return result.results;
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