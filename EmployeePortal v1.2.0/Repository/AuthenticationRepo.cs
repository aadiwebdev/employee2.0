using Domain.StringLiterals;
using System.Configuration;
using System.Data.SqlClient;
using Domain.Interfaces;
using System.Linq;
using Repository.Factory;

namespace Repository
{
    internal class AuthenticationRepo:IAuthenticationRepo
    {
        /// <summary>
        /// It is used to validate login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string ValidateLogin(IModel loginModel)
        {
            using (var context = new Data())
            {
                var result = from s in context.UserInfoes
                             where s.EmailAddress == loginModel.EmailAddress && s.Password == loginModel.Password
                             select s;
                return result.Count()==1? StringLiterals._loginSuccess : StringLiterals._loginFailed;

            }
        }
        /// <summary>
        /// It is used to register user.
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns></returns>
        public string RegisterUser(IModel registrationModel)
        {
            IModel  userModel = registrationModel.GetMappedObject();
            using (var context = new Data())
            {
                if (!IsAlreadyRegistered(userModel))
                {
                    context.UserInfoes.Add(userModel);
                    context.SaveChanges();
                }
            }
             
            return StringLiterals._registrationFailed;
        }
        /// <summary>
        /// It is to check whelther user is already registered or not.
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns></returns>
        public  bool IsAlreadyRegistered(IModel registrationModel)
        {

            using (var context = new Data())
            {
                var result = from s in context.UserInfoes
                             where s.EmailAddress == registrationModel.EmailAddress
                             select s;
                return result.Count() > 0 ? true : false;
            }
        }
    }
}