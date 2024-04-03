using ReginusLTD.Areas.Identity.Data;

namespace ReginusLTD.Models
{
    public class Booking
    {
        public int bookingId { get; set; }
        public int UserId { get; set; }
        public int CounsellorId { get; set; }
        public DateTime Date { get; set; }

        public Counsellor Counsellor { get; set; }
        public ReginusLTDUser ReginusLTDUser { get; set; }
    }
}
