
namespace DrivingApp.Core
{
    public class Condition : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        ICollection<Ride> Rides = null!;

    }
}
