using Feedback.Application.Interfaces.Write;
using Feedback.Domain;

namespace Feedback.Infrastructure.Repositories.Write;

public class WriteRepository : WriteBase<FeedbackItem, FeedbackDbContext>, IFeedbackWriteRepository
{
    public WriteRepository(FeedbackDbContext context) : base(context)
    {
    }
}