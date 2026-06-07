using System.ComponentModel.DataAnnotations;
namespace Spordiklubi_haldus.Models
{
    public class Sport
    {
 
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            public string Description { get; set; }

            public ICollection<Training> Trainings { get; set; }
        }
    }