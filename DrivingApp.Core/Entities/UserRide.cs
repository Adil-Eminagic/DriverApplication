
namespace DrivingApp.Core
{
    public class UserRide : BaseEntity
    {
        public decimal Price { get; set; }
        public float? ReviewRatng { get; set; } = null!;
        public float? ReviewComment { get; set; } = null!;

        public int RideId { get; set; }
        public Ride Ride { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<UserRideComment> Comments { get; set; } = null!;

    }
}
