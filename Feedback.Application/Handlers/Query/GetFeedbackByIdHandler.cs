using Feedback.Application.Interfaces.Read;
using Feedback.Application.Queries;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Query;

public class GetFeedbackByIdHandler : IRequestHandler<GetFeedbackById, FeedbackItem>
{
    private readonly IFeedbackReadRepository _readInterface;

    public GetFeedbackByIdHandler(IFeedbackReadRepository readInterface)
    {
        _readInterface = readInterface;
    }

    public async Task<FeedbackItem> Handle(GetFeedbackById request, CancellationToken cancellationToken)
    {
        var entites = await _readInterface.GetById(request.Id);
        return entites;
    }
}