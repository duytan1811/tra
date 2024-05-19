namespace Travel_ASP.Models
{
    public class Booking : BaseModel
    {
        public Guid TourId { get; set; }
        public virtual Tour Tour { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Message { get; set; }
    }
}
