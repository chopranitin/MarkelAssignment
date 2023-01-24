
namespace MarkelInternationAssignment.Model
{
    public class Claim
    {
        private bool _value;

        public string UCR { get; set; }
        public int CompanyId { get; set; }
        public DateTime ClaimDate { get; set; } = DateTime.Now;
        public DateTime? LossDate { get; set; } = DateTime.Now;
        public string AssuredName { get; set; }
        public decimal IncurredLoss { get; set; }
        public int Closed { get; set; }
            


            
        public int claimDuration => (DateTime.Now - ClaimDate).Days;
    }
}
