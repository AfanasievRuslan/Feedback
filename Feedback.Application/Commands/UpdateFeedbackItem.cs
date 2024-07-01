using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Commands;

public class UpdateFeedbackItem : IRequest<FeedbackItem>
{
    public FeedbackItem feedbackItem { get; set; }
}