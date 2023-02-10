
using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure
{
    public class RideConditionsRepository : BaseRepository<RideCondition, int>, IRideConditionsRepository
    {
        public RideConditionsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
