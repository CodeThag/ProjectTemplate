using System.ComponentModel.DataAnnotations;

namespace Domain.Common;
public abstract class AuditableEntity
{
    [Required]
    [MaxLength(50)]
    public string CreatedBy { get; set; } = new ("Anonymous");
    public DateTime Created { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastModifiedBy { get; set; } = new ("Anonymous");
    public DateTime LastModified { get; set; }
    [MaxLength(50)]
    public string? DeletedBy { get; set; }
    public DateTime? DeletedOn { get; set; }
}
