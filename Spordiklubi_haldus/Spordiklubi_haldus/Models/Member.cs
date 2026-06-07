using System.ComponentModel.DataAnnotations;

namespace Spordiklubi_haldus.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public DateTime JoinDate { get; set; }

        public ICollection<Membership> Memberships { get; set; }
            = new List<Membership>();
    }
}