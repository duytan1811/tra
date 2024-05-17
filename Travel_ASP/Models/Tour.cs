namespace Travel_ASP.Models
{
    public class Tour : BaseModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Detail { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public int? Discount { get; set; }
        public int? MinPeople { get; set; }
        public int? MaxPeople { get; set; }
        public int? DayCount { get; set; }
        public Guid? ProvinceId { get; set; }
        public virtual Province? Province { get; set; }
    }
}
