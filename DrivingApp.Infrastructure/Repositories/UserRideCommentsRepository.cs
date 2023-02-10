
using DrivingApp.Infrastructure.Interfaces;
using DrivingApp.Core;

namespace DrivingApp.Infrastructure
{
    public class UserRideCommentsRepository : BaseRepository<UserRideComment, int>, IUserRideCommentsRepository
    {
        public UserRideCommentsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
