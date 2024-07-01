using System.Collections;
using System.Linq.Expressions;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Queries;

public class GetFeedbackByAuthor : IRequest<ICollection<FeedbackItem>>
{
    public Expression<Func<FeedbackItem,bool>> Predicate { get; set; }
}