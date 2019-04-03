using System.Collections.Generic;
using Domain.Enums;
using Domain.Interfaces;
using Business.Factory;
using Repository.Factory;

namespace Business
{
    internal class UserBusiness : IUserBusiness
    {
        IUserRepo _userRepo = RepositoryFactory.GetUserRepo();
        /// <summary>
        /// It is used to retrieve the details of userlist
        /// </summary>
        /// <param name="userRoleChoice"></param>
        /// <returns></returns>
        public List<IModel> GetUserDetails(UserRoleChoice userRoleChoice)
        {
            return _userRepo.GetUserDetails(userRoleChoice);
        }
    }
}
