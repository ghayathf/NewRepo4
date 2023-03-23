using LearningZone.Core.Data;
using LearningZone.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

        

    }
}
