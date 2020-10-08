using System.Collections.Generic;
using System.Threading.Tasks;
using BrawlStars.Models;

namespace BrawlStars.Contracts.Services
{
    public interface IPlayersServices
    {
        IList<Vehiculos> GetAllVehiculos();
        void InsertVehiculo(Vehiculos vehiculo);
        void DeleteVehiculo(int idVehiculo);
    }
}
