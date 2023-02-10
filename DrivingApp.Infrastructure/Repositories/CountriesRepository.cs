
using DrivingApp.Core.Entities;
using DrivingApp.Infrastructure.Interfaces;

namespace DrivingApp.Infrastructure
{
    public class CountriesRepository : BaseRepository<Country, int>, ICountriesRepository
    {
        public CountriesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
