using System.ComponentModel.DataAnnotations;

namespace Feedback.Domain;

public class FeedbackItem : BaseEntity
{
    [Required] 
    public required string Author { get; set; }
    [Required] 
    public required string Subject { get; set; }
    public string? Message { get; set; }
    [Required]
    public int Score { get; set; }
    [Required]
    public DateTime PublishDate { get; set; }
}