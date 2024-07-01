using System.Collections;
using Feedback.Application.Interfaces.Read;
using Feedback.Application.Queries;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Query;

public class GetFeedbackByAuthorHandler : IRequestHandler<GetFeedbackByAuthor, ICollection<FeedbackItem>>
{
    private readonly IFeedbackReadRepository _readInterface;

    public GetFeedbackByAuthorHandler(IFeedbackReadRepository readInterface)
    {
        _readInterface = readInterface;
    }

    public async Task<ICollection<FeedbackItem>> Handle(GetFeedbackByAuthor request,
        CancellationToken cancellationToken)
    {
        ICollection<FeedbackItem> feedbackItems = await _readInterface.GetByParameter(request.Predicate);
        return feedbackItems;
    }
}