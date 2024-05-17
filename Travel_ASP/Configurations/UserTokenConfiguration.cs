﻿namespace STM.DataAccess.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Travel_ASP.Models;

    public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.HasKey(userToken => new { userToken.UserId, userToken.LoginProvider, userToken.Name });
            builder.Property(userToken => userToken.LoginProvider).HasMaxLength(256);
            builder.Property(userToken => userToken.Name).HasMaxLength(256);

            builder
                .HasOne(userToken => userToken.User)
                .WithMany(user => user.UserTokens)
                .HasForeignKey(userToken => userToken.UserId);
        }
    }
}
