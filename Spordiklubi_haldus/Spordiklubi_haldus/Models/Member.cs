using System.ComponentModel.DataAnnotations; // Lisa see rida faili algusesse!

namespace Spordiklubi_haldus.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Display(Name = "Eesnimi")] // See muudab FirstName -> Eesnimi
        public string FirstName { get; set; }

        [Display(Name = "Perekonnanimi")]
        public string LastName { get; set; }

        [Display(Name = "Liitumise kuupäev")]
        public DateTime JoinDate { get; set; }
    }
}