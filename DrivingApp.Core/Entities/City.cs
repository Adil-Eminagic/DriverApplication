using DrivingApp.Core.Entities;

namespace DrivingApp.Core
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public bool IsActive { get; set; }

        public int CountryId { get; set; }// fk
        public Country Country { get; set; } = null!;// navigator

        public ICollection<MileStone> MileStones { get; set; } = null!;
    }
}
