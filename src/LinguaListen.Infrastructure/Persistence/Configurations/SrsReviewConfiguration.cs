using LinguaListen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinguaListen.Infrastructure.Persistence.Configurations;

public class SrsReviewConfiguration : IEntityTypeConfiguration<SrsReview>
{
    public void Configure(EntityTypeBuilder<SrsReview> builder)
    {
        builder.HasOne(r => r.Card)
            .WithMany(c => c.Reviews)
            .HasForeignKey(r => r.CardId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(r => new { r.CardId, r.ReviewedAt });

        builder.HasQueryFilter(r => r.DeletedAt == null);
    }
}
