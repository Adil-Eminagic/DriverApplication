
namespace DrivingApp.Core
{
    public class MileStone : BaseEntity
    {
        public string LocationName { get; set; } = null!;
        public MileStoneType MileStoneType { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Notes { get; set; }

        public int CityId { get; set; }
        public City City { get; set; } = null!;

        public int RideId { get; set; }
        public Ride Ride { get; set; } = null!;
    }
}
