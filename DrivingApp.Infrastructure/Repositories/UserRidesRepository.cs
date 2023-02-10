
using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure
{
    public class UserRidesRepository : BaseRepository<UserRide, int>, IUserRidesRepository
    {
        public UserRidesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
