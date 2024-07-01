using System.Collections;
using Feedback.Domain;
using MediatR;

namespace Feedback.Application.Queries;

public class GetFeedbackById : IRequest<FeedbackItem>
{
    public string Id { get; set; }
}