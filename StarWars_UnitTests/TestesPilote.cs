using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarWars_DDD.Domain.Interfaces;
using StarWars_DDD.Entités;
using StarWars_DDD.Véhicules_Domain;
using System.Collections.Generic;

namespace EventStormingExample.Tests
{
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