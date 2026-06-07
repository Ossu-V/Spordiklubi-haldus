using Spordiklubi_haldus.Models;
using System.ComponentModel.DataAnnotations;

namespace Spordiklubi_haldus.Data
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime JoinDate { get; set; }

        public ICollection<Membership> Memberships { get; set; }
    }
}
