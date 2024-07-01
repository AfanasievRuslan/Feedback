using System.Collections;
using Feedback.Application.Interfaces.Read;
using Feedback.Application.Queries;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Handlers.Query;

public class GetAllFeedbackItemsHandler(IFeedbackReadRepository readInterface)
    : IRequestHandler<GetCollectionFeedbackItemsCommand, ICollection<FeedbackItem>>
{
    public async Task<ICollection<FeedbackItem>> Handle(GetCollectionFeedbackItemsCommand request,
        CancellationToken cancellationToken)
    {
        var feedbackItems = await readInterface.GetAll();
        return feedbackItems;
    }
}