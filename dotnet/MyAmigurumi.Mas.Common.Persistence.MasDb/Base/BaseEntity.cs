using System.ComponentModel.DataAnnotations;

namespace MyAmigurumi.Mas.Common.Persistence.MasDb.Base;

public class BaseEntity : AuditableEntity
{
    [Key] public Guid Id { get; set; }
}