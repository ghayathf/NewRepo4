using LearningZone.Core.Data;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService commentService;
        public CommentsController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        [HttpPost]
        [Route("CreateComment")]
        public void CreateComment(FinalComment finalComment)
        {
            commentService.CreateComment(finalComment);
        }
        [HttpDelete]
        [Route("DeleteComment/{id}")]
        public void DeleteComment(int id)
        {
            commentService.DeleteComment(id);
        }
        [HttpGet]
        [Route("GetAllComments")]
        public Task<List<FinalComment>> GetAllComments()
        {
            return commentService.GetAllComments();
        }
        [HttpGet]
        [Route("GetCommentById/{id}")]
        public FinalComment GetCommentById(int id)
        {
            return commentService.GetCommentById(id);
        }
        [HttpPut]
        [Route("UpdateComment")]
        public void UpdateComment(FinalComment finalComment)
        {
            commentService.UpdateComment(finalComment);
        }
    }
}
