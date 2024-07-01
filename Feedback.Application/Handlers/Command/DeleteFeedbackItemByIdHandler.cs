using Feedback.Application.Commands;
using Feedback.Application.Interfaces.Write;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Command;

public class DeleteFeedbackItemByIdHandler : IRequestHandler<DeleteFeedbackItemByIdCommand, FeedbackItem> 
{
    private readonly IFeedbackWriteRepository _wrtiteInterface;

    public DeleteFeedbackItemByIdHandler(IFeedbackWriteRepository wrtiteInterface)
    {
        _wrtiteInterface = wrtiteInterface;
    }
    public async Task<FeedbackItem> Handle(DeleteFeedbackItemByIdCommand request, CancellationToken cancellationToken)
    {
        FeedbackItem deleteFeedback = await _wrtiteInterface.DeleteById(request.Id);
        return deleteFeedback;
    }
}