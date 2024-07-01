using System.Collections;
using Feedback.Application.Commands;
using Feedback.Application.Interfaces.Write;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Command;

public class DeleteFeedbackRangeByParameterHandler : IRequestHandler<DeleteFeedbackRangeByParamaterCommand, ICollection<FeedbackItem>>
{
    private readonly IFeedbackWriteRepository _writeInterface;

    public DeleteFeedbackRangeByParameterHandler(IFeedbackWriteRepository writeInterface)
    { 
        _writeInterface = writeInterface;
    }
    public async Task<ICollection<FeedbackItem>> Handle(DeleteFeedbackRangeByParamaterCommand request, CancellationToken cancellationToken)
    {
        ICollection<FeedbackItem> deleteFeedback = await _writeInterface.DeleteRangeByParameter(request.Predicate);
        return deleteFeedback;
    }
}