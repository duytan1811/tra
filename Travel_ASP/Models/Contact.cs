namespace Travel_ASP.Models
{
    public class Contact : BaseModel
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
    }
}
