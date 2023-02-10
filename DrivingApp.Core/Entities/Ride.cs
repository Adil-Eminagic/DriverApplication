
namespace DrivingApp.Core
{
    public class Ride : BaseEntity
    {
        public decimal Price { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int MaxPassengers { get; set; }
        public PaymentType PaymentType { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string? Notes { get; set; }

        public int DriverId { get; set; }
        public User Driver { get; set; } = null!;

        public ICollection<MileStone> MileStones { get; set; } = null!;
        public ICollection<RideCondition> Conditions { get; set; } = null!;
        public ICollection<UserRide> Passengers { get; set; } = null!;
    }
}
