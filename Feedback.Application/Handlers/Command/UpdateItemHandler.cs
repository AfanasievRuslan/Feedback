using Feedback.Application.Commands;
using Feedback.Application.Interfaces.Write;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Command;

public class UpdateItemHandler(IFeedbackWriteRepository writeRepository)
    : IRequestHandler<UpdateFeedbackItem, FeedbackItem>
{
    public async Task<FeedbackItem> Handle(UpdateFeedbackItem request, CancellationToken cancellationToken)
    {
        await writeRepository.Add(request.feedbackItem);
        return request.feedbackItem;
    }
}