namespace Travel_ASP.ViewModels
{
    public class SettingViewModel
    {
        public IFormFile? DefaultTourImage { get; set; }
        public IFormFile? DefaultBlogImage { get; set; }
        public string? AppName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
