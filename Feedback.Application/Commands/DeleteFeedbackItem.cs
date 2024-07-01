using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Commands;

public class DeleteFeedbackItem : IRequest<FeedbackItem>
{
    public FeedbackItem feedbackItem;
}