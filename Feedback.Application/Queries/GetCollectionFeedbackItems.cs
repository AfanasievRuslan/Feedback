using System.Collections;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Queries;

public class GetCollectionFeedbackItems : IRequest<ICollection<FeedbackItem>>
{
    
}