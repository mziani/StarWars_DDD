/*
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarWars_DDD.Domain;
using StarWars_DDD.Domain.Interfaces;
using StarWars_DDD.Entités;
using StarWars_DDD.Véhicules_Domain;
using System.Collections.Generic;

namespace EventStormingExample.Tests
{
    using global::StarWars_DDD.Application.Commands;
    using global::StarWars_DDD.Application.Handlers;
    
    [TestClass]
    public class PilotTests
    {

        [TestMethod]
        public void Pilote_ConduirToutVehicules_DoitConduirToutVehicules()
        {
            
            var starship = new Starship();
            var airspeeder = new Airspeeder();

            var vehicules = new List<IVehicule> { starship, airspeeder };
            var pilote = new Pilote(vehicules);

            
            pilote.ConduirToutVehicules();

            // Assert
            Assert.IsTrue(starship.DemarrerAppellee);
            Assert.IsTrue(starship.EmbarquerAppellee);
            Assert.IsTrue(starship.ArreterAppellee);


            Assert.IsTrue(airspeeder.DemarrerAppellee);
            Assert.IsTrue(airspeeder.EmbarquerAppellee);
            Assert.IsTrue(airspeeder.ArreterAppellee);

            // Vérifier que les méthodes spécifiques ne sont pas appelées pour Airspeeder
            Assert.IsFalse(airspeeder is IVehiculeSpecifique);
        }
    }
}
    */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StarWars_DDD.Application;
using StarWars_DDD.Application.Commands;
using StarWars_DDD.Application.Handlers;
using StarWars_DDD.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace StarWars_DDD.Tests
{
    [TestClass]
    public class StarshipTests
    {
        [TestMethod]
        public void FetchAllStarshipsCommand_Should_Return_All_Starships()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpClient>();
            var httpClientResponse = new HttpResponseMessage()
            {
                Content = new StringContent(GetSampleStarshipApiResponse())
            };
            mockHttpClient.Setup(c => c.GetAsync("https://swapi.dev/api/starships"))
                            .ReturnsAsync(httpClientResponse);
            var fetchAllStarshipsCommand = new FetchAllStarshipsCommand(mockHttpClient.Object);
            var fetchAllStarshipsHandler = new FetchAllStarshipsCommandHandler();

            // Act
            var allStarships = fetchAllStarshipsCommand.Execute();
            fetchAllStarshipsCommand.SuccessHandler = fetchAllStarshipsHandler;
            fetchAllStarshipsHandler.Handle(allStarships);

            // Assert
            Assert.IsNotNull(allStarships);
            Assert.AreEqual(3, allStarships.Count);
        }

        [TestMethod]
        public void FetchOneStarshipCommand_Should_Return_One_Starship()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpClient>();
            var httpClientResponse = new HttpResponseMessage()
            {
                Content = new StringContent(GetSampleStarshipApiResponse(2))
            };
            mockHttpClient.Setup(c => c.GetAsync("https://swapi.dev/api/starships/2"))
                            .ReturnsAsync(httpClientResponse);
            var fetchOneStarshipCommand = new FetchOneStarshipCommand(mockHttpClient.Object);
            fetchOneStarshipCommand.StarshipId = 2;
            var fetchOneStarshipHandler = new FetchOneStarshipCommandHandler();

            // Act
            var starship = fetchOneStarshipCommand.Execute();
            fetchOneStarshipCommand.SuccessHandler = fetchOneStarshipHandler;
            fetchOneStarshipHandler.Handle(starship);

            // Assert
            Assert.IsNotNull(starship);
            Assert.AreEqual("CR90 corvette", starship.Name);
            Assert.AreEqual("corvette", starship.Model);
            Assert.AreEqual("Corellian Engineering Corporation", starship.Manufacturer);
        }

        private string GetSampleStarshipApiResponse(int starshipId = 0)
        {
            if (starshipId == 0)
            {
                return @"{
                        ""results"": [
                            {
                                ""name"": ""Executor"",
                                ""model"": ""Executor-class star dreadnought"",
                                ""manufacturer"": ""Kuat Drive Yards""
                            },
                            {
                                ""name"": ""Sentinel-class landing craft"",
                                ""model"": ""Sentinel-class landing craft"",
                                ""manufacturer"": ""Sienar Fleet Systems""
                            },
                            {
                                ""name"": ""Death Star"",
                                ""model"": ""DS-1 Orbital Battle Station"",
                                ""manufacturer"": ""Imperial Department of Military Research, Sienar Fleet Systems""
                            }
                        ]
                    }";
            }
            else if (starshipId == 2)
            {
                return @"{
                        ""name"": ""CR90 corvette"",
                        ""model"": ""corvette"",
                        ""manufacturer"": ""Corellian Engineering Corporation""
                    }";
            }
            else
            {
                return "";
            }
        }
    }
}
