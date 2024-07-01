using System.Linq.Expressions;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Queries;

public class GetFeedbackByScore : IRequest<ICollection<FeedbackItem>>
{
    public Expression<Func<FeedbackItem, bool>> Predicate { get; set; }
}