using Travel_ASP.Models;

namespace Travel_ASP.ViewModels
{
    public class BookingViewModel
    {
        public Guid TourId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Message { get; set; }
    }
}
