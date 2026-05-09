using LinguaListen.Domain.Common;
using LinguaListen.Domain.Enums;

namespace LinguaListen.Domain.Entities;

public class TranscriptionSession : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string? Title { get; set; }
    public string Language { get; set; } = string.Empty;
    public SessionSourceType SourceType { get; set; }
    public string? SourceUrl { get; set; }

    public ICollection<VocabularyEntry> VocabularyEntries { get; set; } = [];
}
