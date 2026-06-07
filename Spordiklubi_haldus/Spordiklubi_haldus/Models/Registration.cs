using Spordiklubi_haldus.Data;

namespace Spordiklubi_haldus.Models
{
    public class Registration
    {
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int TrainingId { get; set; }
        public Training Training { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}