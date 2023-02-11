
using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure
{
    public class VehiclesRepository : BaseRepository<Vehicle, int>, IVehiclesRepository
    {
        public VehiclesRepository(DatabaseContext database) : base(database)
        {

        }
    }
}
