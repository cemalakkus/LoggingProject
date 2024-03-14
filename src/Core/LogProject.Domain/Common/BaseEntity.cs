namespace CQRSProject.Domain.Common;

public class BaseEntity
{
    public Guid Id { get;set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public string LastModifiedBy { get; set; } = string.Empty;
    public DateTime? LastModified { get; set; }
}
