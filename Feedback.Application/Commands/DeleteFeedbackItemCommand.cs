using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Commands;

public class DeleteFeedbackItemCommand : IRequest<FeedbackItem>
{
    public FeedbackItem feedbackItem;
}