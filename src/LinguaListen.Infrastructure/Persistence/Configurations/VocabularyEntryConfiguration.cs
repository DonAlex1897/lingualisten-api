using LinguaListen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinguaListen.Infrastructure.Persistence.Configurations;

public class VocabularyEntryConfiguration : IEntityTypeConfiguration<VocabularyEntry>
{
    public void Configure(EntityTypeBuilder<VocabularyEntry> builder)
    {
        builder.Property(v => v.Term)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(v => v.Language)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(v => v.Definitions)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.Property(v => v.Examples)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.Property(v => v.Pronunciation)
            .HasMaxLength(300);

        builder.Property(v => v.PronunciationAudioUrl)
            .HasMaxLength(2000);

        builder.Property(v => v.ImageUrl)
            .HasMaxLength(2000);

        builder.Property(v => v.Context)
            .HasMaxLength(1000);

        builder.HasOne(v => v.User)
            .WithMany(u => u.VocabularyEntries)
            .HasForeignKey(v => v.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(v => v.Session)
            .WithMany(s => s.VocabularyEntries)
            .HasForeignKey(v => v.SessionId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasIndex(v => new { v.UserId, v.Term, v.Language });

        builder.HasQueryFilter(v => v.DeletedAt == null);
    }
}
