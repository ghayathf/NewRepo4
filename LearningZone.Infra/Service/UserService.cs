using LearningZone.Core.Data;
using LearningZone.Core.Repository;
using LearningZone.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void CREATEUser(FinalUser user)
        {
            userRepository.CREATEUser(user);
        }

        public void DELETEUser(int id)
        {
            userRepository.DELETEUser(id);
        }

        public List<FinalUser> GETALLUsers()
        {
          return  userRepository.GETALLUsers();
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
