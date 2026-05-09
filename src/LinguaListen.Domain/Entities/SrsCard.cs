using LinguaListen.Domain.Common;

namespace LinguaListen.Domain.Entities;

public class SrsCard : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int VocabularyEntryId { get; set; }
    public VocabularyEntry VocabularyEntry { get; set; } = null!;
    public int Interval { get; set; } = 1;
    public int Repetitions { get; set; } = 0;
    public float EaseFactor { get; set; } = 2.5f;
    public DateTime DueDate { get; set; }
    public DateTime? LastReviewedAt { get; set; }

    public ICollection<SrsReview> Reviews { get; set; } = [];
}
