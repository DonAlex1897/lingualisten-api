using LinguaListen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinguaListen.Infrastructure.Persistence.Configurations;

public class SrsCardConfiguration : IEntityTypeConfiguration<SrsCard>
{
    public void Configure(EntityTypeBuilder<SrsCard> builder)
    {
        builder.HasOne(c => c.VocabularyEntry)
            .WithOne(v => v.SrsCard)
            .HasForeignKey<SrsCard>(c => c.VocabularyEntryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.User)
            .WithMany(u => u.SrsCards)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(c => c.EaseFactor)
            .HasPrecision(4, 2);

        builder.HasIndex(c => new { c.UserId, c.DueDate });

        builder.HasQueryFilter(c => c.DeletedAt == null);
    }
}
