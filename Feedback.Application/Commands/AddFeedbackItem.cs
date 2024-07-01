using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Commands;

public class AddFeedbackItem : IRequest<FeedbackItem>
{
    public FeedbackItem feedbackItem { get; set; }
}