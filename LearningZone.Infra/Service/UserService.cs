﻿using LearningZone.Core.Data;
using LearningZone.Core.DTO;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LearningZone.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public List<TrainerInfo> GetTrainerInfoByUserId(int usid)
        {
            return userRepository.GetTrainerInfoByUserId(usid);
        }
        public string Auth(FinalUser login)
        {
            var result = userRepository.Auth(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SuperSecretKeyLMSProjectttttttt"));
                var signin = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                    new Claim("Username", result.Username),
                    new Claim("RoleId", result.RoleId.ToString()),
                    new Claim("Userid", result.Userid.ToString()),
                    new Claim("Firstname", result.Firstname),
                    new Claim("Lastname", result.Lastname),
                    new Claim("Phonenumber", result.Phonenumber),
                    new Claim("Email", result.Email),
                    new Claim("Imagename", result.Imagename),

                };
                var tokenOptions = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddSeconds(60),
                    signingCredentials: signin);
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return tokenString;
            }
        }

        public void CREATEUser(FinalUser user)
        {
            userRepository.CREATEUser(user);
        }

        public void DELETEUser(int id)
        {
            userRepository.DELETEUser(id);
        }

        public async Task<List<FinalUser>> GETALLUsers()
        {
          return await userRepository.GETALLUsers();
        }

        public FinalUser GetUserByID(int id)
        {
            return userRepository.GetUserByID(id);
        }

        public void UpdateUser(FinalUser user)
        {
           userRepository.UpdateUser(user);
        }
    }
}
