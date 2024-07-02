using Feedback.Application.Interfaces.Read;
using Feedback.Domain;
using System.Linq.Expressions;

namespace Feedback.Infrastructure.Repositories.Read;

public class ReadRepository : ReadBase<FeedbackItem, FeedbackDbContext>, IFeedbackReadRepository
{
    public ReadRepository(FeedbackDbContext context) : base(context) 
    {
    } 
}