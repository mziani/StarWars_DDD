using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars_DDD.Interfaces
{
    public interface IVehicule
    {
        void Demarrer();
        void Arreter();
        void Embarquer();
        void Tourner();
        string GetVehicleType();
    }
}
