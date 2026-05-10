using LinguaListen.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinguaListen.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<RefreshToken> RefreshTokens { get; }
    DbSet<TranscriptionSession> Sessions { get; }
    DbSet<VocabularyEntry> VocabularyEntries { get; }
    DbSet<SrsCard> SrsCards { get; }
    DbSet<SrsReview> SrsReviews { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
