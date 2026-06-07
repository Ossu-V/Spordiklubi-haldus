using System.ComponentModel.DataAnnotations;

namespace Spordiklubi_haldus.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Eesnimi")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Perekonnanimi")]
        public string LastName { get; set; }

        [Display(Name = "Eriala")]
        public string Specialization { get; set; }
    }
}