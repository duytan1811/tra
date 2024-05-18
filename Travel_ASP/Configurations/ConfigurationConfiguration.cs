namespace STM.DataAccess.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Travel_ASP.Models;

    public class ConfigurationConfiguration : IEntityTypeConfiguration<Configuration>
    {
        public void Configure(EntityTypeBuilder<Configuration> builder)
        {

            var configKey = new List<string>
            {
                "appName",
                "phone",
                "email",
                "defaultTourImage",
                "defaultBlogImage"
            };

            foreach (var key in configKey)
            {
                builder.HasData(
                    new Configuration()
                    {
                        Id = Guid.NewGuid(),
                        Key = key,
                        Value = ""
                    });
            }
        }
    }
}
