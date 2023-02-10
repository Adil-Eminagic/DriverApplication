
using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure
{
    public class RidesRepository : BaseRepository<Ride, int>, IRidesRepository
    {
        public RidesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
