namespace Spordiklubi_haldus.Models
{
    public class Membership
    {
        public int Id { get; set; }

        public string MembershipType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int MemberId { get; set; }

        public Member Member { get; set; }
    }
}
