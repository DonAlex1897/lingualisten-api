using LinguaListen.Application.Common.Interfaces;
using LinguaListen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LinguaListen.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IApplicationDbContext
{

    public DbSet<User> Users => Set<User>();
    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();
    public DbSet<TranscriptionSession> Sessions => Set<TranscriptionSession>();
    public DbSet<VocabularyEntry> VocabularyEntries => Set<VocabularyEntry>();
    public DbSet<SrsCard> SrsCards => Set<SrsCard>();
    public DbSet<SrsReview> SrsReviews => Set<SrsReview>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
