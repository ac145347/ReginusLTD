namespace ReginusLTD.Models
{
    public class Counsellor
    {
        public int CounsellorId { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public ICollection<Counsellor> Counsellors { get; set; }

    }
}
