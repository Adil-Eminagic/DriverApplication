
namespace DrivingApp.Core
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public Role Role { get; set; }
        public DateTime? LastSignIn { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }

        public int? ProfilePhotoId { get; set; }
        public Photo? ProfilePhoto { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = null!; 
        public ICollection<Ride> Rides { get; set; } = null!; // putovanja kao vozac
        public ICollection<UserRide> UserRides { get; set; } = null!; // putovanja kao putnik



    }
}
