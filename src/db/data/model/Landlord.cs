
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.db.data.model
{
    public class Landlord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long LandlordId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        public Landlord(string name)
        {
            Name = name;
        }

        // Used for seed data
        public Landlord(long landlodId, string name)
        {
            LandlordId = landlodId;
            Name = name;
        }
    }
}
