using Common.Types;

namespace Models.Entities;

public class Response: IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArchivedAt { get; set; }
    
    public string Contents { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}