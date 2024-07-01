using System.ComponentModel.DataAnnotations;

namespace Feedback.Domain;

public class BaseEntity
{
    [Key]
    public string Id { get; set; }
}