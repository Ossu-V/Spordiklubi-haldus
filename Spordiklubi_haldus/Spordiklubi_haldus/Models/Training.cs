using System.ComponentModel.DataAnnotations;

namespace Spordiklubi_haldus.Models
{
    public class Training
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime TrainingDate { get; set; }

        public int MaximumMembers { get; set; }
        public int SportId { get; set; }
        public Sport Sport { get; set; }

        public ICollection<Registration> Registrations { get; set; }
    }
}