
using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure.Repositories
{
    public class MileStonesRepository : BaseRepository<MileStone, int>, IMileStonesRepository
    {
        public MileStonesRepository(DatabaseContext database) : base(database)
        {

        }
    }
}
