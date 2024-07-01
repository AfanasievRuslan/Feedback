using Feedback.Application.Commands;
using Feedback.Application.Interfaces.Write;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Command;

public class AddItemHandler(IFeedbackWriteRepository writeInterface) : IRequestHandler<AddFeedbackItem, FeedbackItem>
{
    public async Task<FeedbackItem> Handle(AddFeedbackItem request, CancellationToken cancellationToken)
    {
        await writeInterface.Add(request.feedbackItem);
        return request.feedbackItem;
    }
}