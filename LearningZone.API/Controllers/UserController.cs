using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LearningZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        [Route("GetUserByTraineeInfo/{usid}")]
        public List<TrainerInfo> GetTrainerInfoByUserId(int usid)
        {
            return userService.GetTrainerInfoByUserId(usid);
        }
        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(FinalUser user)
        {
            userService.CREATEUser(user);

        }
        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public void DeleteUser(int id)
        {
            userService.DELETEUser(id);
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<List<FinalUser>> GETALLUsers()
        {
            return await userService.GETALLUsers();
        }
        [HttpGet]
        [Route("GetUserByID/{id}")]
        public FinalUser GetUserByID(int id)
        {
            return userService.GetUserByID(id);
        }
        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateTraineeSection(FinalUser user)
        {
            userService.UpdateUser(user);
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Auth([FromBody] FinalUser login)
        {
            var token = userService.Auth(login);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }
        [Route("UploadImage")]
        [HttpPost]
        public FinalUser UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\LearningHub_Angular\\src\\assets\\HomeAssets\\images", fileName);

            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            FinalUser item = new FinalUser();
            item.Imagename = fileName;
            return item;
        }

        

    }
}
