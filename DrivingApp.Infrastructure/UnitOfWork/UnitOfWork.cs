
using DrivingApp.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace DrivingApp.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _dbContext;
        public readonly ICitiesRepository CityRepository;
        public readonly IConditionsRepository ConditionRepository;
        public readonly ICountriesRepository CountryRepository;
        public readonly IMileStonesRepository MileStonesRepository;
        public readonly IPhotosRepository PhotosRepository;
        public readonly IRideConditionsRepository RideConditionsRepository;
        public readonly IRidesRepository RidesRepository;
        public readonly IUserRideCommentsRepository UserRideCommentsRepository;
        public readonly IUsersRepository UsersRepository;
        public readonly IUserRidesRepository UserRidesRepository;
        public readonly IVehiclesRepository VehiclesRepository;

        public UnitOfWork(DatabaseContext dbContext, ICitiesRepository cityRepository, IConditionsRepository conditionRepository, ICountriesRepository countryRepository, IMileStonesRepository mileStonesRepository, IPhotosRepository photosRepository, IRideConditionsRepository rideConditionsRepository, IRidesRepository ridesRepository, IUserRideCommentsRepository userRideCommentsRepository, IUsersRepository usersRepository, IUserRidesRepository userRidesRepository, IVehiclesRepository vehiclesRepository)
        {
            _dbContext = dbContext;
            CityRepository = cityRepository;
            ConditionRepository = conditionRepository;
            CountryRepository = countryRepository;
            MileStonesRepository = mileStonesRepository;
            PhotosRepository = photosRepository;
            RideConditionsRepository = rideConditionsRepository;
            RidesRepository = ridesRepository;
            UserRideCommentsRepository = userRideCommentsRepository;
            UsersRepository = usersRepository;
            UserRidesRepository = userRidesRepository;
            VehiclesRepository = vehiclesRepository;
        }



        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return _dbContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransaction(CancellationToken cancellationToken = default)
        {
            await _dbContext.Database.CommitTransactionAsync(cancellationToken);
        }

        public async Task RollBackTransaction(CancellationToken cancellationToken = default)
        {
            await _dbContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
