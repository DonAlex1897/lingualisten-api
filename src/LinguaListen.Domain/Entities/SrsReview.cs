using LinguaListen.Domain.Common;

namespace LinguaListen.Domain.Entities;

public class SrsReview : BaseEntity
{
    public int CardId { get; set; }
    public SrsCard Card { get; set; } = null!;
    public DateTime ReviewedAt { get; set; }
    public int Quality { get; set; }
    public int PreviousInterval { get; set; }
    public int NewInterval { get; set; }
}
