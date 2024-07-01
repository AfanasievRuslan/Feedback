using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Commands;

public class DeleteFeedbackItemByIdCommand: IRequest<FeedbackItem>
{
    public string Id { get; set; }
}