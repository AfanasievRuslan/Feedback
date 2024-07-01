using System.Collections;
using System.Linq.Expressions;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Commands;

public class DeleteFeedbackRangeByParamaterCommand : IRequest<ICollection<FeedbackItem>>
{
    public Expression<Func<FeedbackItem, bool>> Predicate;
}