using LearningZone.Core.Data;
using LearningZone.Core.Service;
using LearningZone.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private readonly IReplyService replyService;
        public ReplyController(IReplyService replyService)
        {
            this.replyService = replyService;
        }
        [HttpPost]
        [Route("CreateReply")]
        public void CreateCourse(FinalReply finalReply)
        {
            replyService.CreateCourse(finalReply);
        }
        [HttpDelete]
        [Route("DeleteReply/{id}")]
        public void DeleteCourse(int id)
        {
            replyService.DeleteCourse(id);
        }
        [HttpGet]
        [Route("GetAllReplies")]
        public List<FinalReply> GetAllCourses()
        {
            return replyService.GetAllCourses();
        }
        [HttpGet]
        [Route("GetReplyById/{id}")]
        public FinalReply GetCourseById(int id)
        {
            return replyService.GetCourseById(id);
        }
        [HttpPut]
        [Route("UpdateReply")]
        public void UpdateCourse(FinalReply finalReply)
        {
            replyService.UpdateCourse(finalReply);
        }
    }
}
