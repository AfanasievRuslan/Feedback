using Feedback.Application.Commands;
using Feedback.Application.Interfaces.Write;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Command;

public class DeleteItemHandler(IFeedbackWriteRepository writeRepository)
    : IRequestHandler<DeleteFeedbackItem, FeedbackItem>
{
    public async Task<FeedbackItem> Handle(DeleteFeedbackItem request, CancellationToken cancellationToken)
    {
        await writeRepository.Add(request.feedbackItem);
        return request.feedbackItem;
    }
}