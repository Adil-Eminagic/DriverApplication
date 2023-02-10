

using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure
{
    public class ConditionsRepository : BaseRepository<Condition, int>, IConditionsRepository
    {
        public ConditionsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
