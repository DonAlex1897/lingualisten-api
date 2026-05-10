using LinguaListen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinguaListen.Infrastructure.Persistence.Configurations;

public class TranscriptionSessionConfiguration : IEntityTypeConfiguration<TranscriptionSession>
{
    public void Configure(EntityTypeBuilder<TranscriptionSession> builder)
    {
        builder.Property(s => s.Language)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(s => s.Title)
            .HasMaxLength(200);

        builder.Property(s => s.SourceUrl)
            .HasMaxLength(2000);

        builder.HasOne(s => s.User)
            .WithMany(u => u.Sessions)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasQueryFilter(s => s.DeletedAt == null);
    }
}
