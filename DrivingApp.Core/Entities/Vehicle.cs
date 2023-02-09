
namespace DrivingApp.Core
{
    public class Vehicle : BaseEntity
    {
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Notes { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
