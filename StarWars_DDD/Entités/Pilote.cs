using StarWars_DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars_DDD.Entités
{
    public class Pilote
    {
        private readonly List<IVehicule> _vehicules;

        public Pilote(List<IVehicule> vehicules)
        {
            _vehicules = vehicules;
        }
        public void ConduirToutVehicules()
        {
            foreach (var vehicule in _vehicules)
            {
                vehicule.Demarrer();
                vehicule.Embarquer();

                if (vehicule is IVehiculeSpecifique specificVehicle)
                {
                    specificVehicle.Tirer();
                    specificVehicle.Voler();
                }

                vehicule.Arreter();
                Console.WriteLine($"Pilot a conduit le véhicule : {vehicule.GetVehicleType()}.");
            }
        }

    }
}
