using LinguaListen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinguaListen.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(256);

        builder.HasIndex(u => u.Email)
            .IsUnique();

        builder.Property(u => u.DisplayName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.GoogleId)
            .HasMaxLength(100);

        builder.HasIndex(u => u.GoogleId)
            .IsUnique()
            .HasFilter("[GoogleId] IS NOT NULL");

        builder.Property(u => u.EmailConfirmationToken)
            .HasMaxLength(500);

        builder.Property(u => u.PasswordResetToken)
            .HasMaxLength(500);

        builder.HasQueryFilter(u => u.DeletedAt == null);
    }
}
