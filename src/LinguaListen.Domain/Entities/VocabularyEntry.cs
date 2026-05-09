using LinguaListen.Domain.Common;

namespace LinguaListen.Domain.Entities;

public class VocabularyEntry : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int? SessionId { get; set; }
    public TranscriptionSession? Session { get; set; }
    public string Term { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;
    public string Definitions { get; set; } = "[]";
    public string Pronunciation { get; set; } = string.Empty;
    public string? PronunciationAudioUrl { get; set; }
    public string Examples { get; set; } = "[]";
    public string? ImageUrl { get; set; }
    public string? Context { get; set; }
    public string? Notes { get; set; }

    public SrsCard? SrsCard { get; set; }
}
