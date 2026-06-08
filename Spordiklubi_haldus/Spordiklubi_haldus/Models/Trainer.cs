using System.ComponentModel.DataAnnotations;

namespace Spordiklubi_haldus.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "Sport")]
        public string Specialization { get; set; }
    }
}