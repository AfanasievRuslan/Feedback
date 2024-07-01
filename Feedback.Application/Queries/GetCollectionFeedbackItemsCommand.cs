using System.Collections;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Queries;

public class GetCollectionFeedbackItemsCommand : IRequest<ICollection<FeedbackItem>>
{
    
}