using Common.Types;

namespace Models.Entities;

public class Prompt: IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArchivedAt { get; set; }
    
    public string Message { get; set; }
    public int? CreatedByUserId { get; set; }
    public virtual User? CreatedByUser { get; set; }
}