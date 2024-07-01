using System.Linq.Expressions;
using Feedback.Application.Commands;
using Feedback.Application.Queries;
using Feedback.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Feedback.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FeedbackController : ControllerBase
{
    private readonly ILogger<FeedbackController> _logger;

        private readonly IMediator _mediator;

        public FeedbackController(ILogger<FeedbackController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddFeedbackItem(FeedbackItem feedback)
        {
            var command = new AddFeedbackItemCommand() { feedbackItem = feedback };
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllFeedbackItems()
        {
            var command = new GetCollectionFeedbackItems();
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetFeedbackById(string feedbackId)
        {
            var command = new GetFeedbackById() { Id = feedbackId};
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetByScore")]
        public async Task<IActionResult> GetFeedbackByScore(int score)
        {
            Expression<Func<FeedbackItem, bool>> predicate = x => x.Score == score;
            var command = new GetFeedbackByScore() { Predicate = predicate};
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetByAuthor")]
        public async Task<IActionResult> GetFeedbackByAuthor(string author)
        {
            Expression<Func<FeedbackItem, bool>> predicate = x => x.Author == author;
            var command = new GetFeedbackByAuthor() { Predicate = predicate };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateFeedbackItem(FeedbackItem feedback)
        {
            var command = new UpdateFeedbackItemCommand() { feedbackItem = feedback};
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteFeedbackItem(FeedbackItem feedback)
        {
            var command = new DeleteFeedbackItemCommand() { feedbackItem = feedback };
            var result = await _mediator.Send(command);

            return Ok(result);
        }
        [HttpDelete]
        [Route("DeleteById")]
        public async Task<IActionResult> DeleteFeedbackItemById(string id) 
        {
            var command = new DeleteFeedbackItemByIdCommand() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete]
        [Route("DeleteRangeByAuthor")]
        public async Task<IActionResult> DeleteRangeFeedbackByAuthor(string author) 
        {
            Expression<Func<FeedbackItem, bool>> predicate = x => x.Author == author;
            var command = new DeleteFeedbackRangeByParamaterCommand() { Predicate = predicate };
            await _mediator.Send(command);
            return Ok();
        }
}