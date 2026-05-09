using LinguaListen.Domain.Common;

namespace LinguaListen.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string? PasswordHash { get; set; }
    public string DisplayName { get; set; } = string.Empty;
    public string? GoogleId { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public string? EmailConfirmationToken { get; set; }
    public DateTime? EmailConfirmationTokenExpiresAt { get; set; }
    public string? PasswordResetToken { get; set; }
    public DateTime? PasswordResetTokenExpiresAt { get; set; }

    public ICollection<RefreshToken> RefreshTokens { get; set; } = [];
    public ICollection<TranscriptionSession> Sessions { get; set; } = [];
    public ICollection<VocabularyEntry> VocabularyEntries { get; set; } = [];
    public ICollection<SrsCard> SrsCards { get; set; } = [];
}
