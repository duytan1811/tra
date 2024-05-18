namespace Travel_ASP.ViewModels
{
    public class BlogViewModel
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageImport { get; set; }
    }
}
