using System.Threading.Tasks;
using BrawlStars.Models;
using System.Collections.Generic;
using BrawlStars.Contracts.Services;

namespace BrawlStars.Services
{
    public class PlayersServices : IPlayersServices
    {
        public Player GetPlayer(string )
        {
            return _VehiculosRepository.GetAllVehiculos();
        }
        public void InsertVehiculo(Vehiculos vehiculo)
        {
            _VehiculosRepository.InsertVehiculo(vehiculo);
        }

        public void DeleteVehiculo(int idVehiculo)
        {
            _VehiculosRepository.DeleteVehiculo(idVehiculo);
        }

    }
}