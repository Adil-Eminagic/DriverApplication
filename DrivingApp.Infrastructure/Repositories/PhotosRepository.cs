
using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure
{
    public class PhotosRepository : BaseRepository<Photo, int>, IPhotosRepository
    {
        public PhotosRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
