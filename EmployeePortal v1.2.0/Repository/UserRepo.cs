using Domain.Enums;
using System.Collections.Generic;
using System.Data;
using Domain.Interfaces;
using Repository.Factory;

using System.Linq;
using Domain;

namespace Repository
{
    internal class UserRepo:IUserRepo
    {
        /// <summary>
        /// Getting the user details as per the choice of the user.
        /// </summary>
        /// <param name="userRoleChoice"></param>
        /// <returns></returns>
        public List<IModel> GetUserDetails(UserRoleChoice userRoleChoice)
        {
            
            List<UserInfo> userDetails=null;

            using (var context = new Data())
            {
                    switch ((int)userRoleChoice)
                    {
                        case 1:
                        userDetails = context.UserInfoes.Where(s => s.IsStudent =="true").ToList();
                                break;
                        case 2:
                        userDetails = context.UserInfoes.Where(s => s.IsStudent == "false").ToList();
                                break;
                        case 3:
                        userDetails = context.UserInfoes.ToList();
                                break;
                    }
            }
            return Mapper(userDetails); ;
        }

        private List<IModel> Mapper(List<UserInfo> users)
        {
            IModel model;  
            List<IModel> userdetails= new List<IModel>();
            foreach (var item in users)
            {
                model = ModelFactory.GetModel(ModelSelection.User);
                model.FirstName = item.FirstName;
                model.LastName = item.LastName;
                model.EmailAddress = item.EmailAddress;
                model.Password = item.Password;
                model.IsStudent = item.IsStudent;
                userdetails.Add(model);
            }
            
            return userdetails;
        }
    }
}